using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace HackerRank.StringBiggerIsGreater
{
    public static class Counter
    {
        public static string biggerIsGreater(string w)
        {
            var pointer = w.Length - 1;

            while (pointer > 0)
            {
                var current = w[pointer];
                var previous = w[pointer - 1];

                if (current <= previous)
                {
                    pointer--;
                    continue;
                }

                var letters = w.Substring(pointer)
                    .ToCharArray()
                    .OrderBy(x => x)
                    .ToList();
                
                var first = letters.First(x => x > previous);
                var firstIdx = letters.IndexOf(first);
                letters[firstIdx] = previous;

                var result = pointer > 1 
                    ? $"{w.Substring(0, pointer - 1)}{first}{string.Concat(letters.OrderBy(x => x).ToList())}"
                    : $"{first}{string.Concat(letters.OrderBy(x => x).ToList())}";

                return result;
            }

            return "no answer";
        }
    }
}