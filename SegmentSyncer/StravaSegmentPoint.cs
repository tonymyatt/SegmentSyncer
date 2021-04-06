using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentSyncer
{
    [Serializable]
    public class StravaSegmentPoint
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public float Distance { get; set; }
        public float Time { get; set; }
        public float Altitude { get; set; }

        public StravaSegmentPoint()
        {
            Latitude = -1;
            Longitude = -1;
            Distance = -1;
            Time = -1;
            Altitude = -1;
        }
    }
}
