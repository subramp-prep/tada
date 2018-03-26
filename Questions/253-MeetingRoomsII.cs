using System;
namespace questions
{
    public class MeetingRoomsII
    {
        // Question URL: https://leetcode.com/problems/meeting-rooms-ii/description/
        //Given an array of meeting time intervals consisting of 
        //start and end times[[s1, e1],[s2, e2],...] (si<ei), find 
        //the minimum number of conference rooms required.
        //For example,
        //Given[[0, 30],[5, 10],[15, 20]],
        //return 2.

        public static int MinMeetingRooms(Interval[] intervals)
        {
            if (intervals.Length <= 0)
            {
                return 0;
            }

            int[] starts = new int[intervals.Length];
            int[] ends = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                starts[i] = intervals[i].start;
                ends[i] = intervals[i].end;
            }

            Array.Sort(starts);
            Array.Sort(ends);
            int rooms = 0;
            int endsItr = 0;
            for (int i = 0; i < starts.Length; i++)
            {
                if (starts[i] < ends[endsItr])
                    rooms++;
                else
                    endsItr++;
            }
            return rooms;


            //// sort input array based on the start times
            //Array.Sort(intervals, (x, y) => x.start - y.start);

            //for (int i = 1; i < intervals.Length; i++)
            //{
            //    if (intervals[i - 1].end > intervals[i].start)
            //    {
            //        meetingRoomCount++;
            //    }
            //}
            //return meetingRoomCount;
        }
    }
}
