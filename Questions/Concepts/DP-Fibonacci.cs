using System;
namespace questions
{
    public class DP_Fibonacci
    {
        public static int FibonacciRecursive(int n)
        {
            if (n == 0)
                return 0;
            
            if (n == 1)
                return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        private static int[] fib = new int[50];
        public static int FibonacciDP(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            if (fib[n] != 0)
                return fib[n];

            fib[n] = FibonacciDP(n-1) + FibonacciDP(n - 2);

            return fib[n];
        }
    }
}
