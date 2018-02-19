using System;
namespace questions
{
    public class Utils
    {
        public static void swap(ref int a, ref int b)
        {
            int temp = 0;

            temp = a;
            a = b;
            b = temp;
        }
    }
}
