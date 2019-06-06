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
        [TestMethod()]
        public void ThreeSumTest_Leetcode_case46()
        {
            var input = new int[] { 1,-1,-1,0 };
            var result = new List<List<int>>
            {
                new List<int>()
                {
                    -1,0,1
                }
            };
            var solution = new ThreeSumSolution().ThreeSum(input);
        }

        [TestMethod()]
        public void ThreeSumTest_Leetcode_case52()
        {
            var input = new int[] { -2, 0, 1, 1, 2};
            var result = new List<List<int>>
            {
                new List<int>()
                {
                    -1,0,1
                }
            };
            var solution = new ThreeSumSolution().ThreeSum(input);
        }

        [TestMethod()]
        public void ThreeSumTest_Leetcode_case65()
        {
            var input = new int[] { 0, -4, -1, -4, -2, -3, 2 };
            var result = new List<List<int>>
            {
                new List<int>()
                {
                    -1,0,1
                }
            };
            var solution = new ThreeSumSolution().ThreeSum(input);
        }


        [TestMethod()]
        public void ThreeSumTest_Leetcode_case57()
        {
            var input = new int[] { 3, 0, -2, -1, 1, 2 };
            var result = new List<List<int>>
            {
                new List<int>()
                {
                    -1,0,1
                }
            };
            var solution = new ThreeSumSolution().ThreeSum(input);
        }
    }
}