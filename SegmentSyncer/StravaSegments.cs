using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegmentSyncer
{
    class StravaSegments
    {
        public StravaSegments()
        {
            segmentList = FileHelper.ReadFromXmlFile<List<StravaSegment>>("segments.xml");
        }

        private List<StravaSegment> segmentList;

        /// <summary> 
        /// Stored Segments
        /// </summary> 
        public List<StravaSegment> Segments
        {
            get { return segmentList; }
        }

        public void Add(StravaSegment segment)
        {
            segmentList.Add(segment);
            Save();
        }

        public void Remove(StravaSegment segment)
        {
            segmentList.Remove(segment);
            Save();
        }

        public void Sort()
        {
            segmentList.Sort();
        }

        public void Save()
        {
            FileHelper.WriteToXmlFile<List<StravaSegment>>("segments.xml", Segments);
        }
    }
}
