using Algorithms.HackerRank;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Algo.HackerRankTests
{
    [TestFixture]
    class StaircaseTests
    {

        [Test]
        [TestCase(6)]
        [TestCase(12)]
        [TestCase(190)]
        public void GenerateStaircaseBaseFloor_Returns_BaseFloorWithLengthEqualN(int n)
        {
            var staircase = new Staircase();
            
            var baseFloor = staircase.CreateStaircaseFloor(n);

            Assert.AreEqual(n, baseFloor.Length);

        }
        
    }
}
