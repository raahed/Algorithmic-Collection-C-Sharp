namespace Algorithmic_Collection
{
    public partial class Algorithm
    {
        private static uint[] memo = new uint[500];

        public static long Fibonacci(uint n)
        {
            if (n == 1 || n == 2)
                return 1;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static uint FibonacciWithMemo(uint n)
        {
            if (memo[n] != 0)
                return memo[n];

            if (n == 1 || n == 2)
                return 1;

            uint result = FibonacciWithMemo(n - 1) + FibonacciWithMemo(n - 2);
            memo[n] = result;
            return result;
        }

        public static uint FibonacciBottomUp(uint n)
        {
            if (n == 1 || n == 2)
                return 1;

            uint[] bottomUp = new uint[n + 1];
            bottomUp[1] = bottomUp[2] = 1;

            for (int i = 3; i <= n; i++)
                bottomUp[i] = bottomUp[i - 1] + bottomUp[i - 2];

            return bottomUp[n];
        }
    }
}
