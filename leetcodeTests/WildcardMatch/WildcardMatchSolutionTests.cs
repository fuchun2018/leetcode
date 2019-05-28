using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.WildcardMatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.WildcardMatch.Tests
{
    [TestClass()]
    public class WildcardMatchSolutionTests
    {
        [TestMethod()]
        public void IsMatchTest()
        {
            var solution = new WildcardMatchSolution();
            var input = "aa ";
            var pattern = "a";
            var result = solution.IsMatch(input, pattern);
            Assert.IsFalse(result);
        }
        [TestMethod()]
        public void IsMatchTestWithQuestionMark()
        {
            var solution = new WildcardMatchSolution();
            var input = "aa";
            var pattern = "??";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod()]
        public void IsMatchTestWithAsteriskMark()
        {
            var solution = new WildcardMatchSolution();
            var input = "aa";
            var pattern = "*";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
    }
}