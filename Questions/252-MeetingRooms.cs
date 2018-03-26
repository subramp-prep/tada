using System;
using System.Collections.Generic;

namespace questions
{
    public class MeetingRooms
    {
        // Question URL: https://leetcode.com/problems/meeting-rooms/description/
        //Given an array of meeting time intervals consisting of start and end times
        //[[s1, e1],[s2, e2],...] (si<ei), determine if a person could attend all meetings.

        //For example,
        //Given[[0, 30],[5, 10],[15, 20]],
        //return false.

        public static bool CanAttendMeetings(Interval[] intervals)
        {
            if (intervals.Length <= 0)
            {
                return true;
            }

            // sort input array based on the start times
            Array.Sort(intervals, (x, y) => x.start - y.start);

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i-1].end > intervals[i].start )
                {
                    return false;
                }
            }

            return true;
        }
    }
}
