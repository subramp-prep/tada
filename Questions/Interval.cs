using System;
using System.Collections.Generic;

namespace questions
{
    public class Interval
    {
        public int start { get; set; }
        public int end { get; set; }

        public Interval()
        {
            start = 0;
            end = 0;
        }

        public Interval(int s, int e)
        {
            start = s;
            end = e;
        }

        public static Interval[] CreateMany(IList<int[]> startEndTimes)
        {
            List<Interval> intervals = new List<Interval>();
            foreach (var startEndTime in startEndTimes)
            {
                intervals.Add(new Interval(startEndTime[0], startEndTime[1]));
            }

            return intervals.ToArray();
        }
    }
}
