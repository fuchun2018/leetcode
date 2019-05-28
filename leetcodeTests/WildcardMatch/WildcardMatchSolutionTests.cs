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
        [TestMethod]
        public void IsMatch_Case_4()
        {
            var solution = new WildcardMatchSolution();
            var input = "adceb";
            var pattern = "a*b";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsMatch_Case_5()
        {
            var solution = new WildcardMatchSolution();
            var input = "acdcb";
            var pattern = "a*c?b";
            var result = solution.IsMatch(input, pattern);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsMatch_EmptyString()
        {
            var solution = new WildcardMatchSolution();
            var input = "aaa";
            var pattern = "*";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase3()
        {
            var solution = new WildcardMatchSolution();
            var input = "abceb";
            var pattern = "*a*b";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase5()
        {
            var solution = new WildcardMatchSolution();
            var input = "aab";
            var pattern = "c*a*b";
            var result = solution.IsMatch(input, pattern);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase1397()
        {
            var solution = new WildcardMatchSolution();
            var input = "aa";
            var pattern = "a*";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase1432()
        {
            var solution = new WildcardMatchSolution();
            var input = "ab";
            var pattern = "?*";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase1538()
        {
            var solution = new WildcardMatchSolution();
            var input = "a";
            var pattern = "a*";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase1600()
        {
            var solution = new WildcardMatchSolution();
            var input = "b";
            var pattern = "?*?";
            var result = solution.IsMatch(input, pattern);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase1769()
        {
            var solution = new WildcardMatchSolution();
            var input = "aa";
            var pattern = "*";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase1798()
        {
            var solution = new WildcardMatchSolution();
            var input = "";
            var pattern = "*";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void IsMatch_LeetcodeCase1802()
        {
            var solution = new WildcardMatchSolution();
            var input = "ho";
            var pattern = "**ho";
            var result = solution.IsMatch(input, pattern);
            Assert.IsTrue(result);
        }
    }
}