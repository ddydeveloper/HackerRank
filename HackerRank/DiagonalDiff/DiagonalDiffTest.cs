using System;
using System.Collections.Generic;
using HackerRank;
using NUnit.Framework;

public class Tests
{
    [Test]
    public void CountTest()
    {
        var _1Line = new List<int> {4,3,2,1};
        var _2Line = new List<int> {8,7,6,5};
        var _3Line = new List<int> {0,4,1,2};
        var _4Line = new List<int> {9,3,1,7};

        var result = Counter.diagonalDifference(new List<List<int>> {_1Line, _2Line, _3Line, _4Line});
        
        Assert.True(result == 1);
    }
}