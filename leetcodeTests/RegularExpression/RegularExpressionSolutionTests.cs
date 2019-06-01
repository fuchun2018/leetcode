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
        [TestMethod()]
        public void IsMatchTest_Case2()
        {
            Assert.IsTrue(new RegularExpressionSolution().IsMatch("ab", ".*"));
        }
        [TestMethod()]
        public void IsMatchTest_Case3()
        {
            Assert.IsFalse(new RegularExpressionSolution().IsMatch("mississippi", "mis*is*p*."));
        }

        [TestMethod()]
        public void IsMatchTest_Leetcode_394()
        {
            Assert.IsTrue(new RegularExpressionSolution().IsMatch("aaa", "ab*ac*a"));
        }

        [TestMethod()]
        public void IsMatchTest_Leetcode_404()
        {
            Assert.IsTrue(new RegularExpressionSolution().IsMatch("aaa", "ab*a*c*a"));
        }
    }
}