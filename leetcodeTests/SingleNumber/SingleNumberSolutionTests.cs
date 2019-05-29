using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.SingleNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.SingleNumber.Tests
{
    [TestClass()]
    public class SingleNumberSolutionTests
    {
        [TestMethod()]
        public void SingleNumberTest()
        {
            var solution = new SingleNumberSolution();
            var result = solution.SingleNumber(new int[] { 4, 1, 2, 1, 2 });
            Assert.AreEqual(result, 4);
        }
    }
}