using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.ThreeSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ThreeSum.Tests
{
    [TestClass()]
    public class ThreeSumSolutionTests
    {
        [TestMethod()]
        public void ThreeSumTest()
        {
            var input = new int[] { -1, 0, 1, 2, -1, -4 };
            var result = new List<List<int>>
            {
                new List<int>()
                {
                    -1, 0, 1
                },
                new List<int>()
                {
                    -1, -1, 2
                }
            };
            var solution = new ThreeSumSolution().ThreeSum(input);
        }
        [TestMethod()]
        public void ThreeSumTest_Case2()
        {
            var input = new int[] { 0,0,0,0 };
            var result = new List<List<int>>
            {
                new List<int>()
                {
                    0,0,0
                }
            };
            var solution = new ThreeSumSolution().ThreeSum(input);
        }
    }
}