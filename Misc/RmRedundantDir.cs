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
        HashSet<string> RemoveRedundantFileDirs(string[] dirs)
        {
            HashSet<string> output = new HashSet<string>();

            if (dirs.Length <= 0)
                return output;

            if (dirs[0][0] == '\\')
                output.Add(dirs[0]);

            foreach (var dir in dirs)
            {
                if (dir[0] != '\\')
                    continue;

                foreach (var element in output)
                {
                    if (element.Length > dir.Length)
                    {
                        if (element.StartsWith(dir, StringComparison.CurrentCultureIgnoreCase))
                        {
                            // potential match
                            output.Remove(element);
                        }

                        if (!output.Contains(dir))
                            output.Add(dir);
                        //break;
                    }
                    else
                    {
                        if (!dir.StartsWith(element, StringComparison.CurrentCultureIgnoreCase) && 
                            !output.Contains(dir))
                            output.Add(dir);
                    }
                }
            }

            return output;
        }
    }
}
