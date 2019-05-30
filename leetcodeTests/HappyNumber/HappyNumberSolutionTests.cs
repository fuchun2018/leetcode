using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.HappyNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.HappyNumber.Tests
{
    [TestClass()]
    public class HappyNumberSolutionTests
    {
        [TestMethod()]
        public void IsHappyTest()
        {
            //https://en.wikipedia.org/wiki/Happy_number
            Assert.IsTrue(new HappyNumberSolution().IsHappy(1));
            Assert.IsTrue(new HappyNumberSolution().IsHappy(7));
            Assert.IsTrue(new HappyNumberSolution().IsHappy(10));
            Assert.IsTrue(new HappyNumberSolution().IsHappy(13));
            Assert.IsTrue(new HappyNumberSolution().IsHappy(19));
            Assert.IsTrue(new HappyNumberSolution().IsHappy(23));
        }

        [TestMethod()]
        public void IsHappyTest_Case2()
        {
            Assert.IsFalse(new HappyNumberSolution().IsHappy(2));
            Assert.IsFalse(new HappyNumberSolution().IsHappy(27));
            Assert.IsFalse(new HappyNumberSolution().IsHappy(30));
            Assert.IsFalse(new HappyNumberSolution().IsHappy(43));
            Assert.IsFalse(new HappyNumberSolution().IsHappy(59));
            Assert.IsFalse(new HappyNumberSolution().IsHappy(83));
        }
    }
}