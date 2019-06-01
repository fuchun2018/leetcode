using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.TrapRainWater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.TrapRainWater.Tests
{
    [TestClass()]
    public class TrapRainWaterSolutionTests
    {
        [TestMethod()]
        public void TrapTest()
        {
            var solution = new TrapRainWaterSolution();
            var input = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            var result = solution.Trap(input);
            Assert.AreEqual(result, 6);
        }

        [TestMethod()]
        public void TrapTest_leetcode_testcase_4()
        {
            var solution = new TrapRainWaterSolution();
            var input = new int[] { 0, 2, 0 };
            var result = solution.Trap(input);
            Assert.AreEqual(result, 0);
        }


        [TestMethod()]
        public void TrapTest_leetcode_testcase_18()
        {
            var solution = new TrapRainWaterSolution();
            var input = new int[] { 2, 0, 2 };
            var result = solution.Trap(input);
            Assert.AreEqual(result, 2);
        }

        [TestMethod()]
        public void TrapTest_Case2()
        {
            var solution = new TrapRainWaterSolution();
            var input = new int[] { 0, 5, 3, 4, 0 };
            var result = solution.Trap(input);
            Assert.AreEqual(result, 1);
        }
    }
}