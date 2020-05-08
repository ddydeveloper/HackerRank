using System;


namespace HackerRank.PlusMinus
{
    using System;
    using System.Collections.Generic;
    using HackerRank;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void CountTest()
        {
            var data = new int[] {-4, 3, -9, 0, 4, 1, };
            var result = Counter.plusMinus(data);
        }
    }
}