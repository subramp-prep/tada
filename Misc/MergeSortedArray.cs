using System;
namespace Misc
{
    public class MergeSortedArray
    {
        public static void PrintMergeList()
        {
            int[] my_list = { 3,4,6,10,11,15};
            int[] alices_list = { 1,5,8,12,14,19};

            int my = 0, alice = 0;

            while (my < my_list.Length && alice < alices_list.Length)
            {
                if(my_list[my] < alices_list[alice])
                {
                    Console.Write(my_list[my++] + " ");    
                }
                else
                {
                    Console.Write(alices_list[alice++] + " ");
                }
            }

            while (my < my_list.Length)
            {
                Console.Write(my_list[my++] + " ");
            }

            while (alice < alices_list.Length)
            {
                Console.Write(alices_list[alice++] + " ");
            }
        }
    }
}
