using System;
using System.Collections.Generic;

namespace questions
{
    public class BitwiseSubarray
    {

        public static int SubarrayBitwiseORs(int[] A)
        {
            HashSet<int> ans = new HashSet<int>();
            HashSet<int> cur = new HashSet<int>();
            cur.Add(0);
            foreach (int x in A)
            {
                HashSet<int> cur2 = new HashSet<int>();

                foreach (int y in  cur)
                    cur2.Add(x | y);
                
                cur2.Add(x);
                cur = cur2;
                ans.UnionWith(cur);
            }

            return ans.Count;
        }

        //public static int SubarrayBitwiseORs(int[] A)
        //{
        //    Array.Sort(A);

        //    IList<int> chosen = new List<int>();
        //    IList <IList<int>> output = new List<IList<int>>();

        //    SubsetHelper(A, chosen, output, 0);

        //    HashSet<int> uniqueORs = new HashSet<int>();

        //    foreach (var element in output)
        //    {
        //        if (element.Count > 0)
        //        {
        //            int local = 0;
        //            foreach (var item in element)
        //            {
        //                local |= item;
        //            }

        //            if (!uniqueORs.Contains(local))
        //            {
        //                uniqueORs.Add(local);
        //            }
        //        }

        //    }

        //    return uniqueORs.Count;
        //}

        //private static void SubsetHelper(int[] nums, IList<int> chosen, IList<IList<int>> output, int start)
        //{
        //    output.Add(new List<int>(chosen));

        //    for (int i = start; i < nums.Length; i++)
        //    {
        //        chosen.Add(nums[i]);
        //        SubsetHelper(nums, chosen, output, i + 1);
        //        chosen.RemoveAt(chosen.Count - 1);
        //    }
        //}
    }
}
