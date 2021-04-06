using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentSyncer
{
    [Serializable]
    public class StravaEffort
    {
        public StravaEffort()
        {
            this.Id = -1;
            this.Stream = null;
        }

        public StravaEffort(long id, string effortStreamJson)
        {
            this.Id = id;
            this.Stream = new StravaSegmentStream(effortStreamJson);
            // DEBUG Console.WriteLine("Creating Stream");
            // DEBUG this.Stream.ConsolePrint();
        }

        /// <summary>
        /// Stream of the effort
        /// </summary>
        public StravaSegmentStream Stream { get; set; }

        /// <summary>
        /// Strava effort id
        /// </summary>
        public long Id { get; set; }
    }
}
