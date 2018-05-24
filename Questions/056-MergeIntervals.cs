using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // https://leetcode.com/problems/merge-intervals/description/
    // Given a collection of intervals, merge all overlapping intervals.

    // For example,
    // Given[1, 3], [2,6], [8,10], [15,18],
    // return [1,6], [8,10], [15,18].
    public class MergeIntervals
    {
        public static IList<Interval> Merge(IList<Interval> intervals)
        {
            IList<Interval> result = new List<Interval>();
            if (intervals != null && intervals.Count <= 0)
            {
                return result;
            }

            Interval[] sortedArray = intervals.ToArray();
            Array.Sort(sortedArray, (Interval x, Interval y) => { return x.start.CompareTo(y.start); });

            result.Add(sortedArray[0]);

            for (int i =1; i < sortedArray.Length; i++)
            {
                if(result.Last().end < sortedArray[i].start)
                {
                    result.Add(sortedArray[i]);
                }
                else
                {
                    result.Last().end = Math.Max(result.Last().end, sortedArray[i].end);
                }
            }

            return result;
        }

        // Below implementation was a BUST!
        public static IList<Interval> Merge_gut(IList<Interval> intervals)
        {
            // TODO fails to add first element
            Array.Sort(intervals.ToArray(), (x, y) => x.start - y.start);

            IList<Interval> output = new List<Interval>();
            for (int i = 1; i < intervals.Count; i++)
            {
                if (intervals[i - 1].end >= intervals[i].start)
                {
                    //Merge
                    output.Add(new Interval(intervals[i - 1].start, intervals[i].end));
                }
                else
                {
                    output.Add(intervals[i]);
                }
            }

            if (intervals.Count == 1)
            {
                output.Add(intervals[0]);
            }

            return output;
        }
    }
}
