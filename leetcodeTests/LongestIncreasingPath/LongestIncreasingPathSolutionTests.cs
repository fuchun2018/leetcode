using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var input = new int[][] { new int[]{ 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            var result = solution.LongestIncreasingPath(input);
            var expection = 4;
            Assert.AreEqual(4, result);
        }
    }
}