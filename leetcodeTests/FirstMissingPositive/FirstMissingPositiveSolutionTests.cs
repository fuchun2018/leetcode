using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.FirstMissingPositive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.FirstMissingPositive.Tests
{
    [TestClass()]
    public class FirstMissingPositiveSolutionTests
    {
        [TestMethod()]
        public void FirstMissingPositiveTest()
        {
            var solution = new FirstMissingPositiveSolution();
            var input = new int[] { 1, 2, 0 };
            var expect = 3;
            var result = solution.FirstMissingPositive(input);
            Assert.AreEqual(expect, result);
        }
    }
}