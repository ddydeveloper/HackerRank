using System;
using System.Numerics;

namespace HackerRank.Factorial
{
    public static class Counter
    {
        public static string extraLongFactorials(int n) {
            var result = new BigInteger(1);
        
            for (var i = 0; n - i > 1; i++)
            {
                result = BigInteger.Multiply(result, n - i);
            }

            return result.ToString();
        }
    }
}