using Dynastream.Fit;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegmentSyncer
{
    public partial class frmMain : Form
    {
        private StravaSegments segments;
        private BackgroundWorker updateWorker = new BackgroundWorker();
        private BackgroundWorker imageWorker = new BackgroundWorker();

        public frmMain()
        {
            InitializeComponent();

            segments = new StravaSegments();
            stravaSegmentsBindingSource.DataSource = segments;

            updateWorker.WorkerReportsProgress = true;
            updateWorker.WorkerSupportsCancellation = true;
            updateWorker.DoWork += new DoWorkEventHandler(UpdateHandler);
            updateWorker.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged);
            updateWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunWorkerCompleted);

            imageWorker.WorkerReportsProgress = true;
            imageWorker.WorkerSupportsCancellation = true;
            imageWorker.DoWork += new DoWorkEventHandler(ImageHandler);
            imageWorker.ProgressChanged += new ProgressChangedEventHandler(ProgressChanged);
            imageWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(RunWorkerCompleted);

            txtStravaId.Text = Properties.Settings.Default.StravaUserId;
            txtStravaUser.Text = Properties.Settings.Default.StravaUserName;
        }

        private void dataStravaSegments_SelectionChanged(object sender, EventArgs e)
        {
            if (!imageWorker.IsBusy)
            {
                imageWorker.RunWorkerAsync();
            }
        }

        private void ImageHandler(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (dataStravaSegments.SelectedRows.Count != 1)
            {
                return;
            }

            StravaSegment segment = this.dataStravaSegments.SelectedRows[0].DataBoundItem as StravaSegment;

            if (segment == null)
            {
                return;
            }

            String segmentImage = "image\\" + segment.Id + ".jpg";

            // Show the current file
            if (System.IO.File.Exists(segmentImage))
            {
                Image img = null;
                try
                {
                    using (var bmpTemp = new Bitmap(segmentImage))
                    {
                        img = new Bitmap(bmpTemp);
                    }
                }
                catch (Exception)
                {
                }
                if (img != null)
                {
                    picMap.Image = img;
                }
            }
            else
            {
                this.picMap.Image = null;
            }

            // Return if cancelled
            if ((worker.CancellationPending == true)) { e.Cancel = true; return; }

            int width = this.picMap.Width;
            int height = this.picMap.Height;

            // Try and download a new file
            WebClient webClient = new WebClient();
            String url = "https://maps.googleapis.com/maps/api/staticmap?size=" + width + "x" + height + "&maptype=satellite&path=color:0xff0000ff|weight:5|enc:" + segment.Polyline + "&format=jpg&zoom=15";
            try
            {
                webClient.DownloadFile(url, segmentImage);
            }
            catch (Exception)
            {
            }

            // Return if cancelled
            if ((worker.CancellationPending == true)) { e.Cancel = true; return; }

            // Load the image file again
            if (System.IO.File.Exists(segmentImage))
            {
                Image img;
                using (var bmpTemp = new Bitmap(segmentImage))
                {
                    img = new Bitmap(bmpTemp);
                }
                if (img != null)
                {
                    picMap.Image = img;
                }
            }
            else
            {
                this.picMap.Image = null;
            }



            // Check if the selection changed during the time this worker was running
            if (dataStravaSegments.SelectedRows.Count != 1)
            {
                return;
            }
            try
            {
                StravaSegment endSegment = this.dataStravaSegments.SelectedRows[0].DataBoundItem as StravaSegment;
                if (segment.Id != endSegment.Id)
                {
                    ImageHandler(sender, e);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                long id = Int64.Parse(tboxSegment.Text);
                segments.Add(new StravaSegment(id));
                segments.Sort();
                stravaSegmentsBindingSource.ResetBindings(false);
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.StackTrace);
            }

            tboxSegment.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataStravaSegments.SelectedRows.Count != 1)
            {
                return;
            }

            StravaSegment segment = this.dataStravaSegments.SelectedRows[0].DataBoundItem as StravaSegment;

            if (segment == null)
            {
                return;
            }

            segments.Remove(segment);
            stravaSegmentsBindingSource.ResetBindings(false);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updateWorker.IsBusy != true)
            {
                updateWorker.RunWorkerAsync();
                btnUpdate.Enabled = false;
                btnCancel.Enabled = true;
            }
        }

        private volatile List<StravaSegment> segmentsToProcess;
        private volatile int done;
        private volatile int total;
        private Object lockStartThread;

        private void UpdateHandler(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            total = 0;
            done = 0;
            lockStartThread = new Object();
            segmentsToProcess = new List<StravaSegment>();
            foreach (StravaSegment segment in segments.Segments)
            {
                segmentsToProcess.Add(segment);
            }

            // Start a number of threads, which will process all the segments until complete
            for (int i = 0; i < 3; i++)
            {
                Thread thread = new Thread(() => updateSegment(worker));
                thread.Start();
            }

            // Wait for all workers to finish
            while (!(done == 5))
            {
                Thread.Sleep(100);
            }
        }

        public void updateSegment(BackgroundWorker worker)
        {
            Console.WriteLine("UpdateSegment worker");
            StravaSegment segment;
            do
            {
                lock (lockStartThread)
                {
                    if (segmentsToProcess.Count > 0)
                    {
                        segment = segmentsToProcess[0];
                        segmentsToProcess.RemoveAt(0);
                        Console.WriteLine("Running " + segment);
                    }
                    else
                    {
                        segment = null;
                        break;
                    }
                }

                segment.setUpdating(true);
                WebClient webClient = new WebClient();
                try
                {
                    String json = webClient.DownloadString("https://www.strava.com/api/v3/segments/" + segment.Id + "?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9");
                    String strSegStream = webClient.DownloadString("https://www.strava.com/api/v3/segments/" + segment.Id + "/streams/latlng,altitude,distanance,time?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9");

                    JObject jSegment = JObject.Parse(json);
                    String name = jSegment["name"].ToString();
                    String polyline = jSegment["map"]["polyline"].ToString();
                    ushort elevation = (ushort)(Double.Parse(jSegment["elevation_high"].ToString()) - Double.Parse(jSegment["elevation_low"].ToString()));

                    segment.Update(name, polyline, json, strSegStream, elevation);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception 1: " + ex.Message);
                    segment.Update("Error Loading Name", "", "", "", 0);
                    worker.ReportProgress(0, "Error Updating Segment " + segment.Id);
                }

                worker.ReportProgress(0, "Segment Info Loaded " + segment.Id);

                try
                {
                    String json = webClient.DownloadString("https://www.strava.com/api/v3/segments/" + segment.Id + "/leaderboard?page=1&per_page=100&access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9");
                    JObject jLeaderboard = JObject.Parse(json);

                    try
                    {
                        String komName = jLeaderboard["entries"][0]["athlete_name"].ToString();
                        long komEffortId = long.Parse(jLeaderboard["entries"][0]["effort_id"].ToString());
                        int komSeconds = Int32.Parse(jLeaderboard["entries"][0]["elapsed_time"].ToString());
                        System.DateTime komDate = System.DateTime.Parse(jLeaderboard["entries"][0]["start_date_local"].ToString());

                        Console.WriteLine("KOM Details: " + komName + " " + komEffortId + " " + komSeconds + " " + komDate);

                        String komEffortUrl = "https://www.strava.com/api/v3/segment_efforts/" + komEffortId + "/streams/latlng,altitude,time?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9";
                        String komEffortJson = webClient.DownloadString(komEffortUrl);

                        segment.UpdateKom(komName, komSeconds, komDate, komEffortId, komEffortJson);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception 2: " + ex.StackTrace);

                        segment.ClearKom();
                        worker.ReportProgress(0, "Error Loading KOM Stream " + segment.Id);
                    }

                    try
                    {
                        foreach (JToken entry in jLeaderboard.GetValue("entries"))
                        {
                            String userId = entry["athlete_id"].ToString();
                            String userName = entry["athlete_name"].ToString();
                            long userEffortId = long.Parse(entry["effort_id"].ToString());
                            int userRank = Int32.Parse(entry["rank"].ToString());
                            int userSeconds = Int32.Parse(entry["elapsed_time"].ToString());
                            System.DateTime userDate = System.DateTime.Parse(entry["start_date_local"].ToString());

                            if (String.Equals(userId, Properties.Settings.Default.StravaUserId))
                            {
                                String userEffortUrl = "https://www.strava.com/api/v3/segment_efforts/" + userEffortId + "/streams/latlng,altitude,time?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9";
                                String userEffortJson = webClient.DownloadString(userEffortUrl);
                                Console.WriteLine(userEffortUrl);
                                segment.UpdateUser(userRank, userSeconds, userDate, userEffortId, userEffortJson);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception 3A " + ex.Message);
                        segment.ClearUser();
                        worker.ReportProgress(0, "Error Loading User Stream " + segment.Id);
                    }

                    worker.ReportProgress(0, "Segment Done " + segment.Id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception 4: " + ex.Message);
                    worker.ReportProgress(0, "Error Saving Segment " + segment.Id);
                }

                // Increment total number of finished updates


                lock (lockStartThread)
                {
                    worker.ReportProgress(0, "Segment Done " + segment.Id);
                    total++;
                }
            } while (segment != null);

            done++;
        }

        /*private void UpdateHandler(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            WebClient webClient;

            total = 0;
            threads = new List<Thread>();
            foreach (StravaSegment segment in segments.Segments)
            {
                // Exit if worker cancelled
                //if ((worker.CancellationPending == true))
                //{
                //    e.Cancel = true;
                //    break;
                //}

                // Create a thread for updating the segment
                Thread thread = new Thread(() => updateSegment(segment, worker));
                threads.Add(thread);
            }

            // Start the first 5 treads, as treads finish, they will start further remaining threads in
            // the threads list
            for(int i=0;i<Math.Min(threads.Count,5);i++)
            {
                threads[0].Start();
                threads.RemoveAt(0);
            }

            // Wait for all workers to finish or to be cancelled
            while (!worker.CancellationPending && !(done == Math.Min(threads.Count, 5)))
            {
                Thread.Sleep(100);
            }

            // Kill all workers if cancelled
            //if (worker.CancellationPending)
            //{
            //    foreach (Thread thread in threads)
            //    {
            //        thread.Abort();
            //    }
            //}
        }

        public void updateSegment(StravaSegment segment, BackgroundWorker worker)
        {
            segment.setUpdating(true);
            WebClient webClient = new WebClient();
            try
            {
                String json = webClient.DownloadString("https://www.strava.com/api/v3/segments/" + segment.Id + "?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9");
                String strSegStream = webClient.DownloadString("https://www.strava.com/api/v3/segments/" + segment.Id + "/streams/latlng,altitude,distanance,time?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9");

                JObject jSegment = JObject.Parse(json);
                String name = jSegment["name"].ToString();
                String polyline = jSegment["map"]["polyline"].ToString();
                ushort elevation = (ushort)(Double.Parse(jSegment["elevation_high"].ToString()) - Double.Parse(jSegment["elevation_low"].ToString()));

                segment.Update(name, polyline, json, strSegStream, elevation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception 1: " + ex.Message);
                segment.Update("Error Loading Name", "", "", "", 0);
                //worker.ReportProgress(0, "Error Updating Segment " + segment.Id);
            }

            //worker.ReportProgress(0, "Segment Info Loaded " + segment.Id);

            try
            {
                String json = webClient.DownloadString("https://www.strava.com/api/v3/segments/" + segment.Id + "/leaderboard?page=1&per_page=100&access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9");
                JObject jLeaderboard = JObject.Parse(json);

                try
                {
                    String komName = jLeaderboard["entries"][0]["athlete_name"].ToString();
                    long komEffortId = long.Parse(jLeaderboard["entries"][0]["effort_id"].ToString());
                    int komSeconds = Int32.Parse(jLeaderboard["entries"][0]["elapsed_time"].ToString());
                    System.DateTime komDate = System.DateTime.Parse(jLeaderboard["entries"][0]["start_date_local"].ToString());

                    Console.WriteLine("KOM Details: " + komName + " " + komEffortId + " " + komSeconds + " " + komDate);

                    String komEffortUrl = "https://www.strava.com/api/v3/segment_efforts/" + komEffortId + "/streams/latlng,altitude,time?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9";
                    String komEffortJson = webClient.DownloadString(komEffortUrl);

                    segment.UpdateKom(komName, komSeconds, komDate, komEffortId, komEffortJson);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception 2: " + ex.StackTrace);

                    segment.ClearKom();
                    //worker.ReportProgress(0, "Error Loading KOM Stream " + segment.Id);
                }

                try
                {
                    foreach (JToken entry in jLeaderboard.GetValue("entries"))
                    {
                        String userId = entry["athlete_id"].ToString();
                        String userName = entry["athlete_name"].ToString();
                        long userEffortId = long.Parse(entry["effort_id"].ToString());
                        int userRank = Int32.Parse(entry["rank"].ToString());
                        int userSeconds = Int32.Parse(entry["elapsed_time"].ToString());
                        System.DateTime userDate = System.DateTime.Parse(entry["start_date_local"].ToString());

                        if (String.Equals(userId, Properties.Settings.Default.StravaUserId))
                        {
                            String userEffortUrl = "https://www.strava.com/api/v3/segment_efforts/" + userEffortId + "/streams/latlng,altitude,time?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9";
                            String userEffortJson = webClient.DownloadString(userEffortUrl);
                            Console.WriteLine(userEffortUrl);
                            segment.UpdateUser(userRank, userSeconds, userDate, userEffortId, userEffortJson);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception 3A " + ex.Message);
                    segment.ClearUser();
                    //worker.ReportProgress(0, "Error Loading User Stream " + segment.Id);
                }

                //worker.ReportProgress(0, "Segment Done " + segment.Id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception 4: " + ex.Message);
                //worker.ReportProgress(0, "Error Saving Segment " + segment.Id);
            }

            // Increment total number of finished updates
            total++;

            lock(lockStartThread)
            {
                worker.ReportProgress(0, "Segment Done " + segment.Id);
                if (threads.Count > 0)
                {
                    threads[0].Start();
                    threads.RemoveAt(0);
                } else
                {
                    done++;
                }
            }
        }*/

        private void RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Make sure the button text is ready for the next update
            btnUpdate.Text = "Update";
            btnUpdate.Enabled = true;
            btnCancel.Enabled = false;


            if ((e.Cancelled == true))
            {
                this.txtStatus.Text = "Worker Cancelled";
            }
            else if (!(e.Error == null))
            {
                this.txtStatus.Text = ("Error: " + e.Error.Message);
            }
            else
            {
                this.txtStatus.Text = "Worker Done";
            }
        }
        private void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the status text field
            this.txtStatus.Text = e.UserState.ToString();

            // Update the table
            dataStravaSegments.Invalidate();
            dataStravaSegments.Update();
            segments.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (StravaSegment segment in segments.Segments)
            {
                String file = "fit\\segment_" + segment.Id + ".fit";

                // Delete the file if it exists
                if (System.IO.File.Exists(file))
                {
                    System.IO.File.Delete(file);
                }

                // Create file encode object
                FileStream fitDest = new FileStream(file, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
                Encode fitEncoder = new Encode(ProtocolVersion.V20);
                fitEncoder.Open(fitDest);

                // Every FIT file MUST contain a 'File ID' message as the first message
                FileIdMesg fileid = new FileIdMesg();
                fileid.SetType(Dynastream.Fit.File.Segment);
                fileid.SetManufacturer(1);
                fileid.SetProduct(65534);
                fileid.SetTimeCreated(new Dynastream.Fit.DateTime(System.DateTime.Now));
                fileid.SetSerialNumber(1);
                fileid.SetNumber(1);
                fitEncoder.Write(fileid);

                // File creator information
                FileCreatorMesg creator = new FileCreatorMesg();
                creator.LocalNum = 1;
                creator.SetHardwareVersion(0);
                creator.SetSoftwareVersion(0);
                fitEncoder.Write(creator);

                // Save segment information
                SegmentIdMesg segmentid = new SegmentIdMesg();
                segmentid.LocalNum = 2;
                segmentid.SetEnabled(Dynastream.Fit.Bool.True);
                segmentid.SetName(segment.Name);
                segmentid.SetUserProfilePrimaryKey(13564470);
                segmentid.SetSport(Sport.Cycling);
                segmentid.SetUuid(segment.Id.ToString());
                segmentid.SetDefaultRaceLeader(0);
                fitEncoder.Write(segmentid);

                // TODO Two options need to be considered
                // when the user is the KOM, should we give them their time
                // and closest rider

                // KOM is index 0
                SegmentLeaderboardEntryMesg leaderboard_kom = new SegmentLeaderboardEntryMesg();
                leaderboard_kom.LocalNum = 3;
                leaderboard_kom.SetActivityId((uint)segment.KomEffort.Id);
                leaderboard_kom.SetMessageIndex(0);
                leaderboard_kom.SetSegmentTime(segment.KomTimeSeconds());
                leaderboard_kom.SetType(SegmentLeaderboardType.Overall);
                fitEncoder.Write(leaderboard_kom);

                // User is index 1
                SegmentLeaderboardEntryMesg leaderboard_user = new SegmentLeaderboardEntryMesg();
                leaderboard_user.LocalNum = 3;
                leaderboard_user.SetActivityId((uint)segment.UserEffort.Id);
                leaderboard_user.SetMessageIndex(1);
                leaderboard_user.SetSegmentTime(segment.UserTimeSeconds());
                leaderboard_user.SetType(SegmentLeaderboardType.PersonalBest);
                fitEncoder.Write(leaderboard_user);

                // Write segment lap information
                /*https://www.strava.com/api/v3/segment_efforts/13279235200/streams/latlng,altitude,time?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9*/
                SegmentLapMesg lap = new SegmentLapMesg();
                lap.SetUuid("" + segment.Id);
                lap.LocalNum = 4;
                lap.SetTotalAscent(segment.Elevation);
                lap.SetTotalDescent(segment.Elevation);
                lap.SetSwcLat(segment.SegmentStream.getPoint(segment.SegmentStream.Length() - 1).Latitude);
                lap.SetSwcLong(segment.SegmentStream.getPoint(segment.SegmentStream.Length() - 1).Longitude);
                lap.SetNecLat(segment.SegmentStream.getPoint(0).Latitude);
                lap.SetNecLong(segment.SegmentStream.getPoint(0).Longitude);
                lap.SetMessageIndex(1);
                lap.SetStartPositionLat(segment.SegmentStream.getPoint(0).Latitude);
                lap.SetStartPositionLong(segment.SegmentStream.getPoint(0).Longitude);
                lap.SetEndPositionLat(segment.SegmentStream.getPoint(segment.SegmentStream.Length() - 1).Latitude);
                lap.SetEndPositionLong(segment.SegmentStream.getPoint(segment.SegmentStream.Length() - 1).Longitude);
                lap.SetTotalDistance(segment.SegmentStream.getPoint(segment.SegmentStream.Length() - 1).Distance);
                lap.SetSport(Sport.Cycling);
                fitEncoder.Write(lap);

                // Write all segment points
                for (int i = 0; i < segment.SegmentStream.Length(); i++)
                {
                    float komTime = segment.KomEffort.Stream.findTimeAtDistance(segment.SegmentStream.getPoint(i).Distance);
                    float userTime = segment.UserEffort.Stream.findTimeAtDistance(segment.SegmentStream.getPoint(i).Distance);

                    SegmentPointMesg point = new SegmentPointMesg();
                    point.LocalNum = 5;
                    point.SetPositionLat(segment.SegmentStream.getPoint(i).Latitude);
                    point.SetPositionLong(segment.SegmentStream.getPoint(i).Longitude);
                    point.SetMessageIndex((ushort)i);
                    point.SetAltitude(segment.SegmentStream.getPoint(i).Altitude);
                    point.SetDistance(segment.SegmentStream.getPoint(i).Distance);
                    point.SetLeaderTime(0, komTime);
                    point.SetLeaderTime(1, userTime);
                    fitEncoder.Write(point);
                }

                // Update header datasize and file CRC
                fitEncoder.Close();
                fitDest.Close();
            }
        }

        private void btnSetUser_Click(object sender, EventArgs e)
        {
            String id = Microsoft.VisualBasic.Interaction.InputBox("Stava User Id?", "Stava Id", Properties.Settings.Default.StravaUserId);
            try
            {
                int stravaId = Int32.Parse(id);

                Properties.Settings.Default.StravaUserId = "" + stravaId;
                txtStravaUser.Text = "";
                Properties.Settings.Default.StravaUserName = "";
                txtStravaId.Text = Properties.Settings.Default.StravaUserId;

                WebClient webClient = new WebClient();
                String json = webClient.DownloadString("https://www.strava.com/api/v3/athletes/" + id + "?access_token=20c4b2b5ec4985c824bf11b619d528737654c6d9");
                JObject jAthletes = JObject.Parse(json);

                Properties.Settings.Default.StravaUserName = jAthletes["firstname"] + " " + jAthletes["lastname"];
                txtStravaUser.Text = Properties.Settings.Default.StravaUserName;

                Properties.Settings.Default.Save();
            }
            catch
            {
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (updateWorker.IsBusy)
            {
                updateWorker.CancelAsync();
                btnUpdate.Enabled = true;
                btnCancel.Enabled = false;
            }
        }

        private void webWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // TODO LOAD WORKER
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!webWorker.IsBusy) {
                webWorker.RunWorkerAsync();
            }
            string path = Application.StartupPath + "\\resource\\map.html";
            this.webBrowser.Url = new Uri(path);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save the map center
            Object center = webBrowser.Document.InvokeScript("eval", new object[] { "String(map.getCenter());" });
            Properties.Settings.Default.MapLocation = center.ToString();

            // Save the map zoom
            Object zoom = webBrowser.Document.InvokeScript("eval", new object[] { "String(map.getZoom());" });
            Properties.Settings.Default.MapZoom = zoom.ToString();

            Properties.Settings.Default.Save();
        }

        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Return if the page is not fully loaded for some reason
            if (webBrowser.ReadyState != WebBrowserReadyState.Complete) {
                return;
            }

            Console.WriteLine("Load Complete");

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String cmd;

            cmd = "map.setCenter(new google.maps.LatLng" + Properties.Settings.Default.MapLocation + ");";
            Console.WriteLine(cmd);
            webBrowser.Document.InvokeScript("eval", new object[] { cmd });

            cmd = "map.setZoom(" + Properties.Settings.Default.MapZoom + ");";
            Console.WriteLine(cmd);
            webBrowser.Document.InvokeScript("eval", new object[] { cmd });
            int i = 0;
            foreach(StravaSegment ss in segments.Segments) {
                cmd = "var Coords = [";
                bool first = true;
                double lat = 0.0;
                double lng = 0.0;
                String title = ss.Name + "You: "+ss.UserTime+" ("+ss.UserPosition+") Kom: "+ss.KomName+" "+ss.KomTime;
                foreach (StravaSegmentPoint ssp in ss.SegmentStream.points)
                {
                    lat = (ssp.Latitude / 2147483648.0 * 180.0);
                    lng = (ssp.Longitude / 2147483648.0 * 180.0);

                    if (!first)
                    {
                        cmd += ",";
                    } else
                    {
                        // Write start point
                        String sttPoint = "new google.maps.Marker({position: { lat: " + lat + ", lng: " + lng + "}, map: map, icon: green_image, title: \"" + title + "\", zIndex: 1});";
                        webBrowser.Document.InvokeScript("eval", new object[] { sttPoint });
                    }
                    first = false;

                    cmd += "{ lat: "+ lat + ", lng: "+ lng + "}";
                }

                // Write end point
                String endPoint = "new google.maps.Marker({position: { lat: " + lat + ", lng: " + lng + "}, map: map, icon: red_image, title: \"" + title + "\", zIndex: 1});";
                webBrowser.Document.InvokeScript("eval", new object[] { endPoint });

                cmd += "];";
                cmd += "var path = new google.maps.Polyline({";
                cmd += "path: Coords,";
                cmd += "geodesic: true,";
                cmd += "strokeColor: "+ ((ss.UserPosition == 1)?"'#00FF00',":"'#FF0000',");
                cmd += "strokeOpacity: 1.0,";
                cmd += "strokeWeight: 2 });";
                cmd += "path.setMap(map);";
                webBrowser.Document.InvokeScript("eval", new object[] { cmd });
                //if (i++ == 10) { break; }
            }
        }
    }
}
