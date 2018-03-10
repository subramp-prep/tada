using System;
using System.Collections.Generic;
using System.Linq;

namespace questions
{
    public class FirstBadVersion
    {
        // Question URL: https://leetcode.com/problems/first-bad-version/description/

        //You are a product manager and currently leading a team to develop a new product.Unfortunately, 
        //the latest version of your product fails the quality check.Since each version is developed based 
        //on the previous version, all the versions after a bad version are also bad.
        //Suppose you have n versions[1, 2, ..., n] and you want to find out the first bad one, 
        //which causes all the following ones to be bad.
        //You are given an API bool isBadVersion(version) which will return whether version is bad.
        //Implement a function to find the first bad version.You should minimize the number of calls to the API.

        public class VersionControl
        {
            public int Version;
            public bool isBad;
        }

        private static List<VersionControl> _versions = new List<VersionControl>();

        public static void Initialize()
        {
            for (int index = 1; index < 4; index++)
            {
                _versions.Add(new VersionControl()
                {
                    isBad = false,
                    Version = index
                });
            }

            for (int index = 4; index <= 10; index++)
            {
                _versions.Add(new VersionControl()
                {
                    isBad = true,
                    Version = index
                });
            }
        }

        public static int FindBadVersion(int max)
        {
            int lo = 1;
            int hi = max;
            int mid = 0;

            while (lo <= hi)
            {
                mid = lo + (hi - lo) / 2;

                if (IsBadVersion(mid))
                    hi = mid - 1;
                else
                    lo = mid + 1;
            }

            return lo;
        }

        private static bool IsBadVersion(int n)
        {
            return !_versions.Where(p => p.Version == n).First().isBad;
        }

    }
}
