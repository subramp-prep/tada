using System;
using System.Collections.Generic;

namespace Misc
{
    // Goal to remove redundant files and return the root
    //Input: ['\abc\def\ghi', '\abc\def', '\abc\uvw', '\xyz']
    //Output:  ['\abc\def', '\abc\uvw', '\xyz']

    //Input: ['\abc\ghi', '\abc\def', '\abc\uvw', '\abc','\abc\xyz\ghi']
    //Output:  ['\abc']

    //Input: ['\abc', '\abc\ghi', '\abc\ghi\uvw']
    //Output: ['\abc']

    //Input: ['\', '\abc', '\abc\ghi', '\abc\ghi\uvw']
    //Output: ['\']

    //Input: ['\abc\ghi', '\abc\def', '\abc\uvw', '\abc','\abc\xyz\ghi', '\xyz']
    //Output:  ['\abc', '\xyz']

    public class RmRedundantDir
    {
        public static HashSet<string> RemoveRedundantFileDirs(string[] dirs)
        {
            HashSet<string> output = new HashSet<string>();

            if (dirs.Length <= 0)
                return output;
            
            foreach (var dir in dirs)
            {
                if (dir[0] != '\\')
                    continue;

                output.RemoveWhere(x => x.StartsWith(dir, StringComparison.CurrentCulture));

                bool shouldAdd = true;
                foreach (var element in output)
                {
                    if (element.Length < dir.Length &&
                        dir.StartsWith(element, StringComparison.CurrentCulture))
                    {
                        shouldAdd = false;
                        break;
                    }
                }

                if (shouldAdd)
                {
                    output.Add(dir);
                }
            }

            return output;
        }
    }
}
