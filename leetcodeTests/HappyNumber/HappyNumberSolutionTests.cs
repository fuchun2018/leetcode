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

            Assert.IsTrue(new HappyNumberSolution().IsHappy(19));
        }
    }
}