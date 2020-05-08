using System;
using System.Collections.Generic;

namespace HackerRank.TimeToString
{
    public class Counter
    {
        private static readonly Dictionary<int, string> _numbersDict = new Dictionary<int, string>
        {
            {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, 
            {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"}, 
            {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"}, {15, "fifteen"},
            {16, "sixteen"}, {17, "seventeen"}, {18, "eighteen"}, {19, "nineteen"}, {20, "twenty"},
            {21, "twenty one"}, {22, "twenty two"}, {23, "twenty three"}, {24, "twenty four"}, {25, "twenty five"},
            {26, "twenty six"}, {27, "twenty seven"}, {28, "twenty eight"}, {29, "twenty nine"}, {0, "zero"}
        };
        
        public static string TimeInWords(int h, int m)
        {
            var hour = _numbersDict[h];
            var nextHour = _numbersDict[h + 1];

            return m switch
            {
                0 => $"{hour} o' clock",
                15 => $"quarter past {hour}",
                30 => $"half past {hour}",
                45 => $"quarter to {nextHour}",
                1 => $"one minute past {hour}",
                59 => $"one minute to {nextHour}",
                _ => (m < 30
                    ? $"{_numbersDict[m]} minutes past {hour}"
                    : $"{_numbersDict[60 - m]} minutes to {nextHour}")
            };
        } 
    }
}