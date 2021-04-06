using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegmentSyncer
{
    [Serializable]
    public class StravaSegment : IComparable<StravaSegment>
    {
        public StravaSegment()
        {
            this.Id = -1;
            this.Name = "Refresh to Load";
            this.UserPosition = -1;
            this.UserTime = null;
            this.UserDate = null;
            this.UserEffort = null;
            this.KomName = null;
            this.KomTime = null;
            this.KomDate = null;
            this.userIcon = new Bitmap(Properties.Resources.flag_grey);
            this.KomEffort = null;
            this.Polyline = null;
            //this.SegmentStream = null;
            this.ValidForFit = false;
        }

        public StravaSegment(long id)
        {
            this.Id = id;
            this.Name = "Refresh to Load";
            this.UserPosition = -1;
            this.UserTime = null;
            this.UserDate = null;
            this.UserEffort = null;
            this.KomName = null;
            this.KomTime = null;
            this.KomDate = null;
            this.userIcon = new Bitmap(Properties.Resources.flag_grey);
            this.KomEffort = null;
            this.Polyline = null;
            //this.SegmentStream = null;
            this.ValidForFit = false;
        }

        /// <summary> 
        /// ID of this Segment
        /// </summary> 
        public long Id { get; set; }

        public String Name { get; set; }

        public Nullable<DateTime> UserDate { get; set; }

        /// <summary> 
        /// User best Time
        /// </summary> 
        private Nullable<TimeSpan> userTime;
        public string UserTime
        {
            get { return userTime.ToString(); }
            set
            {
                try
                {
                    userTime = TimeSpan.Parse(value);
                }
                catch (Exception)
                {
                }
            }
        }

        public float UserTimeSeconds()
        {
            if(!userTime.HasValue)
            {
                return 0;
            }
            return (float)userTime.Value.TotalSeconds;
        }

        /// <summary> 
        /// KOM best Time
        /// </summary> 
        private Nullable<TimeSpan> komTime;
        public string KomTime
        {
            get { return komTime.ToString(); }
            set
            {
                try
                {
                    komTime = TimeSpan.Parse(value);
                }
                catch (Exception)
                {
                }
            }
        }

        public float KomTimeSeconds()
        {
            if (!komTime.HasValue)
            {
                return 0;
            }
            return (float)komTime.Value.TotalSeconds;
        }

        /// <summary> 
        /// King of the Mountain Name
        /// </summary> 
        public String KomName { get; set; }

        /// <summary> 
        /// User Position
        /// </summary> 
        public int UserPosition { get; set; }

        private Bitmap userIcon;

        /// <summary>
        /// User Icon
        /// </summary>
        public Bitmap UserIcon {
            get {
                return userIcon;
            }
        }

        /// <summary> 
        /// User Position
        /// </summary> 
        public Nullable<DateTime> KomDate { get; set; }

        /// <summary> 
        /// Map Encoded Polyline
        /// </summary> 
        public String Polyline { get; set; }

        /// <summary> `
        /// Segment valid to generate a FIT file
        /// </summary> 
        private bool ValidForFit;

        /// <summary>
        /// KOM Effort
        /// </summary>
        public StravaEffort KomEffort { get; set; }

        /// <summary>
        /// User Effort
        /// </summary>
        public StravaEffort UserEffort { get; set; }

        /// <summary>
        /// Segment Steam
        /// </summary>
        public StravaSegmentStream SegmentStream { get; set; }

        /// <summary>
        /// The segment elevation (mix to max)
        /// </summary>
        public ushort Elevation { get; set; }

        public void Update(String name, String polyline, String segment, String segmentStream, ushort elevation)
        {
            this.Name = name;
            this.Polyline = polyline;
            this.Elevation = elevation;
            this.SegmentStream = new StravaSegmentStream(segmentStream);
        }

        public void UpdateKom(String name, int seconds, DateTime date, long effortId, String effortStream)
        {
            bool equal = String.Equals(KomName, name);
            equal &= (komTime != null && komTime.Value.TotalSeconds == seconds);
            equal &= (date.Equals(KomDate));
            if(!equal)
            {
                this.userIcon = new Bitmap(Properties.Resources.flag_red);
            } else
            {
                this.userIcon = new Bitmap(Properties.Resources.flag_blue);
            }
            this.KomName = name;
            this.komTime = new TimeSpan(0, 0, seconds);
            this.KomDate = date;
            this.KomEffort = new StravaEffort(effortId, effortStream);
        }

        public void ClearKom()
        {
            this.KomName = null;
            this.KomTime = null;
            this.KomDate = null;
            this.KomEffort = null;
        }
        
        public void UpdateUser(int rank, int seconds, DateTime date, long effortId, String effortStream)
        {
            bool equal = (rank == UserPosition);
            equal &= (userTime.HasValue && userTime.Value.TotalSeconds == seconds);
            equal &= (date.Equals(UserDate));
            if (!equal)
            {
                this.userIcon = new Bitmap(Properties.Resources.flag_red);
            }
            else
            {
                this.userIcon = new Bitmap(Properties.Resources.flag_blue);
            }

            this.userTime = new TimeSpan(0, 0, seconds);
            this.UserPosition = rank;
            this.UserDate = date;
            this.UserEffort = new StravaEffort(effortId, effortStream);
        }

        public void ClearUser()
        {
            this.UserTime = null;
            this.UserPosition = -1;
            this.UserDate = null;
            this.UserEffort = null;
        }

        public int CompareTo(StravaSegment other)
        {
            // A null value means that this object is greater.
            if (other == null)
            {
                return 1;
            }

            return this.Id.CompareTo(other.Id);
        }

        public void setUpdating(bool updating)
        {
            if(updating)
            {
                this.userIcon = new Bitmap(Properties.Resources.hourglass);
            }
            else
            {
                this.userIcon = new Bitmap(Properties.Resources.flag_grey);
            }
        }
    }
}
