﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.LongestIncreasingPath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LongestIncreasingPath.Tests
{
    [TestClass()]
    public class LongestIncreasingPathSolutionTests
    {
        [TestMethod()]
        public void LongestIncreasingPathTest()
        {
            var solution = new LongestIncreasingPathSolution();
            var input = new int[][] { new int[] { 9, 9, 4 }, new int[] { 6, 6, 8 }, new int[] { 2, 1, 1 } };
            var result = solution.LongestIncreasingPath(input);
            var expection = 4;
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void LongestIncreasingPathTest_Case_2()
        {
            var solution = new LongestIncreasingPathSolution();
            var input = new int[][] { new int[] { 3, 4, 5 }, new int[] { 3, 2, 6 }, new int[] { 2, 2, 1 } };
            var result = solution.LongestIncreasingPath(input);
            var expection = 4;
            Assert.AreEqual(4, result);
        }

        [TestMethod()]
        public void LongestIncreasingPathTest_Case_3()
        {
            var solution = new LongestIncreasingPathSolution();
            var input = new int[][] { new int[] { 1 } };
            var result = solution.LongestIncreasingPath(input);
            var expection = 1;
            Assert.AreEqual(expection, result);
        }

        [TestMethod()]
        public void LongestIncreasingPathTest_Case_4()
        {
            var solution = new LongestIncreasingPathSolution();
            var input = new int[][] { new int[] { 3, 4, 5 }, new int[] { 3, 2, 6 } };
            var result = solution.LongestIncreasingPath(input);
            var expection = 4;
            Assert.AreEqual(expection, result);
        }

        [TestMethod()]
        public void LongestIncreasingPathTest_Case_5()
        {
            var solution = new LongestIncreasingPathSolution();
            var input = new int[][] {  };
            var result = solution.LongestIncreasingPath(input);
            var expection = 0;
            Assert.AreEqual(expection, result);
        }

        [TestMethod()]
        public void LongestIncreasingPathTest_Case_6()
        {
            var solution = new LongestIncreasingPathSolution();
            var input = new int[][] { new int[] { 1, 2, 3, 4, 5, 6 } };
            var result = solution.LongestIncreasingPath(input);
            var expection = 6;
            Assert.AreEqual(expection, result);
        }

    }
}