using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentSyncer
{
    [Serializable]
    public class StravaSegmentStream
    {
        public StravaSegmentPoint[] points { get; set; }

        public StravaSegmentStream()
        {
            points = null;
        }

        public StravaSegmentStream(String strSrteamJson)
        {
            JArray jStream = JArray.Parse(strSrteamJson);

            points = null;

            // Each stream is an arry containing either coordinates (latlng), distance or time numbers
            foreach (JToken entry in jStream)
            {
                // Stream type and number of entries, all streams should have the same orginal size
                // TODO, need to do some error checking making sure all the orginal size fields are
                // the same size for all stream
                String type = entry["type"].ToString();
                String size = entry["original_size"].ToString();

                // DEBUG Console.WriteLine("Creating segment stream with <" + size + "> items");

                // If this is the first stream, create an array of points the length of the stream
                if (points == null)
                {
                    points = new StravaSegmentPoint[Int32.Parse(size)];
                    for (int i = 0; i < points.Length; i++)
                    {
                        points[i] = new StravaSegmentPoint();
                    }
                }

                // Insert into the point array according to the type of data we recieve
                int idx = 0;
                foreach (JToken point in entry["data"])
                {
                    if (String.Equals(type, "latlng"))
                    {
                        String str = point.ToString();
                        str = str.Replace("[", "");
                        str = str.Replace("]", "");
                        String[] tok = str.Split(',');

                        // Points are in microcircles units 2^32 / 180
                        points[idx].Latitude = (int)(float.Parse(tok[0].Trim()) * 2147483648.0 / 180.0);
                        points[idx].Longitude = (int)(float.Parse(tok[1].Trim()) * 2147483648.0 / 180.0);
                    }
                    if (string.Equals(type, "distance"))
                    {
                        points[idx].Distance = float.Parse(point.ToString());
                    }
                    if (string.Equals(type, "time"))
                    {
                        points[idx].Time = float.Parse(point.ToString());
                    }
                    if (string.Equals(type, "altitude"))
                    {
                        points[idx].Altitude = float.Parse(point.ToString());
                    }
                    idx++;
                }

                // DEBUG Console.WriteLine("Read segment stream with <" + idx + "> items");
            }

            // Adjust time and distance to be from zero
            float firstDistance = 0.0F, firstTime = 0.0F;
            bool first = true;
            foreach (StravaSegmentPoint point in points)
            {
                if(first)
                {
                    firstDistance = point.Distance;
                    firstTime = point.Time;
                    first = false;
                }

                point.Distance = point.Distance - firstDistance;
                point.Time = point.Time - firstTime;
            }
        }

        public void ConsolePrint()
        {
            foreach (StravaSegmentPoint point in points)
            {
                Console.WriteLine(point.Latitude + " " + point.Longitude + " " + point.Time + " " + point.Distance);
            }
        }

        public float findTimeAtDistance(float distance)
        {
            int idx;
            for(idx=0; idx<points.Length; idx++)
            {
                StravaSegmentPoint point = points[idx];
                if(distance <= point.Distance)
                {
                    if(idx > 0)
                    {
                        StravaSegmentPoint pointPrev = points[idx - 1];
                        float span = point.Distance - pointPrev.Distance;
                        float offset = distance - pointPrev.Distance;
                        float percent = offset / span;

                        float tSpan = point.Time - pointPrev.Time;

                        // DEBUG Console.WriteLine(span + " " + offset + " " + percent + " " + tSpan + " " + (percent * tSpan)+ " " + (pointPrev.Time + (percent * tSpan)));

                        return pointPrev.Time + (percent * tSpan);
                    } else
                    {
                        return 0.0F;
                    }

                }
            }

            // No matched period found, return end time
            return points[points.Length - 1].Time;
        }

        public int Length()
        {
            return points.Length;
        }

        public StravaSegmentPoint getPoint(int idx)
        {
            return points[idx];
        }
    }
}