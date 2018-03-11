using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    // Question URL; https://leetcode.com/problems/binary-watch/description/
    //A binary watch has 4 LEDs on the top which represent the hours(0-11), and the 6 LEDs on the bottom represent the minutes(0-59).
    //Each LED represents a zero or one, with the least significant bit on the right.
    //For example, the above binary watch reads "3:25".

    //Given a non-negative integer n which represents the number of LEDs that are currently on, return all possible times the watch could represent.

    //Example:

    //Input: n = 1
    //Return: ["1:00", "2:00", "4:00", "8:00", "0:01", "0:02", "0:04", "0:08", "0:16", "0:32"]
    //Note:
    //The order of output does not matter.
    //The hour must not contain a leading zero, for example "01:00" is not valid, it should be "1:00".
    //The minute must be consist of two digits and may contain a leading zero, for example "10:2" is not valid, it should be "10:02".

    public class BinaryWatch
    {
        private static int _dialCount = 10;

        // WARNING: Very inefficient approach, since we have to go through a lot
        public static IList<string> ReadBinaryWatch(int num)
        {
            IList<string> timeCombination = new List<string>();

            if (num <= 0)
            {
                timeCombination.Add("0:00");
            }
            else
            {
                int[] leds = new int[_dialCount];
                for (int index = 0; index < num; index++)
                {
                    leds[index] = 1;
                }

                IList<int> chosen = new List<int>();
                TimePermuteHelper(leds.ToList(), chosen, num, timeCombination);

                foreach (var timeRepresetation in timeCombination)
                {
                    timeCombination.Add(TimeTranslator(timeRepresetation));
                }
            }

            return timeCombination;
        }

        private static void TimePermuteHelper(List<int> input, IList<int> chosen, int charCount, IList<string> output)
        {
            string translatedTime = string.Empty;
            foreach (var element in chosen)
            {
                translatedTime += element;
            }

            if (chosen.Sum() == charCount && 
                chosen.Count == _dialCount &&
                !output.Contains(translatedTime))
            {
                output.Add(translatedTime);
            }
            else
            {
                for (int index = 0; index < input.Count; index++)
                {
                    int c = input[index];
                    chosen.Add(c);
                    input.RemoveAt(index);

                    TimePermuteHelper(input, chosen, charCount, output);

                    input.Insert(index, c);
                    chosen.RemoveAt(chosen.Count - 1);
                }
            }
        }

        public static string TimeTranslator(string input)
        {
            int hour = Convert.ToInt32(input.Substring(0, 4), 2);
            int minute = Convert.ToInt32(input.Substring(5), 2);

            Console.WriteLine("{0}:{1}", hour, 
                              (minute < 10) ? "0" + minute.ToString() : minute.ToString());

            return string.Empty;
        }

        // Very optimum
        public static IList<string> ReadBinaryWatch_Optimum(int num)
        {
            IList<string> timeCombination = new List<string>();


            for (int hourIndex = 0; hourIndex < 12; hourIndex++)
            {
                for (int minuteIndex = 0; minuteIndex < 60; minuteIndex++)
                {
                    if (Utils.countSetBits(hourIndex) + Utils.countSetBits(minuteIndex) == num)
                    {
                        Console.WriteLine("{0}:{1}", hourIndex,
                                          (minuteIndex < 10) ? "0" + minuteIndex.ToString() : minuteIndex.ToString());
                    }
                }
            }

            return timeCombination;
        }
    }
}
