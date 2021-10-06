// https://leetcode.com/problems/climbing-stairs/

namespace AlgoExpert
{
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            return countWays(n);
        }

        static int countWays(int s)
        {
            return fib(s + 1);
        }

        static int fib(int n)
        {
            if (n <= 1)
                return n;
            return fib(n - 1) + fib(n - 2);
        }
    }
}
