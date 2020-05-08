using System;
using Microsoft.VisualBasic;

namespace HackerRank.StringAppendDelete
{
    public static class Counter
    {
        public static bool appendAndDelete(string s, string t, int k)
        {
            var origin = string.IsNullOrWhiteSpace(s) ? string.Empty : s.Trim();
            var destination = string.IsNullOrWhiteSpace(t) ? string.Empty : t.Trim();

            var originLength = origin.Length;
            var destinationLength = destination.Length;

            if (string.Equals(origin, destination))
                return k >= originLength * 2 || k % 2 == 0;

            if (string.IsNullOrEmpty(origin))
                return k >= destinationLength;

            if (string.IsNullOrEmpty(destination))
                return k >= originLength;

            if (k >= originLength + destinationLength)
                return true;

            for (var i = 0; i <= destinationLength || i <= originLength; i++)
            {
                if (i == originLength)
                {
                    var delta = destinationLength - originLength;
                    return k == delta || (k - delta) % 2 == 0;
                }

                if (i == destinationLength)
                {
                    var delta = originLength - destinationLength;
                    return k == delta || (k - delta) % 2 == 0;
                }

                if (origin[i] != destination[i])
                {
                    var delta = originLength + destinationLength - i * 2;
                    return k == delta || (k > delta && (k - delta) % 2 == 0);
                }
            }

            return true;
        }
    }
}