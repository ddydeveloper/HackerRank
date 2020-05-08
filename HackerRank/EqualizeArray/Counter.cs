using System;
using System.Linq;

namespace HackerRank.EqualizeArray
{
    public static class Counter
    {
        public static int EqualizeArray(int[] arr)
        {
            var length = arr.Length;
            
            if (length == 0)
                return -1;

            var numbersDict = arr
                .GroupBy(number => number)
                .ToDictionary(key => key.Key, number => number.Count());

            var maxCount = numbersDict.Max(x => x.Value);

            return length - maxCount;
        }
    }
}