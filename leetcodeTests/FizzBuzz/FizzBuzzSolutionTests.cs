using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzSolutionTests
    {
        [TestMethod()]
        public void FizzBuzzTest()
        {
            var solution = new FizzBuzzSolution();
            var result = solution.FizzBuzz(0);
            Assert.IsNotNull(result);
        }

        [TestMethod()]
        public void FizzBuzzTest_Case_1()
        {
            var solution = new FizzBuzzSolution();
            var result = solution.FizzBuzz(15);
            Assert.IsNotNull(result);
        }
    }
}