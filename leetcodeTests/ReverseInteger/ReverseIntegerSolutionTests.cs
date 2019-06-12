using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.ReverseInteger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ReverseInteger.Tests
{
    [TestClass()]
    public class ReverseIntegerSolutionTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            var solution = new ReverseIntegerSolution();
            //var result = 123 % 100;
            //var res2 = 123 / 100;
            Assert.AreEqual(solution.Reverse(-123), -321);
        }
        [TestMethod]
        public void ReverseTest_LeetcodeCase1027()
        {
            var solution = new ReverseIntegerSolution();
            Assert.AreEqual(solution.Reverse(1534236469), 0);
        }

        [TestMethod]
        public void ReverseTest_LeetcodeCase1027_2()
        {
            var solution = new ReverseIntegerSolution();
            Assert.AreEqual(solution.Reverse(-1534236469), 0);
        }

        [TestMethod]
        public void ReverseTest_LeetcodeCase1027_3()
        {
            var solution = new ReverseIntegerSolution();
            Assert.AreEqual(solution.Reverse(-2147483412), -2143847412);
        }
    }
}