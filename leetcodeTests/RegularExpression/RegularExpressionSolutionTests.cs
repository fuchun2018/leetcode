using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.RegularExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.RegularExpression.Tests
{
    [TestClass()]
    public class RegularExpressionSolutionTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            Assert.IsTrue(new RegularExpressionSolution().IsMatch("aab", "c*a*b"));
        }
    }
}