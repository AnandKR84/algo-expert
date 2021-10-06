//https://leetcode.com/problems/reverse-integer/

using System;

namespace AlgoExpert
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            int reversedInteger = 0;
            bool negative = false;
            if (x < 0)
            {
                negative = true;
                x = Math.Abs(x);
            }

            do
            {
                if (reversedInteger * 10 / 10 == reversedInteger)
                {
                    reversedInteger = reversedInteger * 10 + x % 10;
                    x /= 10;
                }
                else
                {
                    reversedInteger = 0;
                    break;
                }
            } while (x > 0);

            if (negative)
            {
                reversedInteger = reversedInteger * -1;
            }

            return reversedInteger;
        }
    }
}
