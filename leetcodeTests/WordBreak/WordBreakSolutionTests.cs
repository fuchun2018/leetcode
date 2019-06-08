using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.WordBreak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.WordBreak.Tests
{
    [TestClass()]
    public class WordBreakSolutionTests
    {
        [TestMethod()]
        public void WordBreakTest()
        {
            var solution = new WordBreakSolution();
            var s = "catsanddog";
            var dict = new string[] { "cat", "cats", "and", "sand", "dog" };
            var expect = new List<string>
            {
                 "cats and dog",  "cat sand dog"
            };
            var result = solution.WordBreak(s, dict);
            foreach (var item in result)
            {
                Assert.IsTrue(expect.Contains(item));
            }
        }
        [TestMethod]
        public void WordBreakTest_Case2()
        {
            var solution = new WordBreakSolution();
            var s = "";
            var dict = new string[] { "cat", "cats", "and", "sand", "dog" };

            var result = solution.WordBreak(s, dict);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void WordBreakTest_Case3()
        {
            var solution = new WordBreakSolution();
            var s = "catsanddog";
            var dict = new string[] { "cat", "cats", "and" };

            var result = solution.WordBreak(s, dict);
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void WordBreakTest_Case4()
        {
            var solution = new WordBreakSolution();
            var s = "pineapplepenapple";
            var dict = new string[] { "apple", "pen", "applepen", "pine", "pineapple" };

            var result = solution.WordBreak(s, dict);
            Assert.AreNotEqual(0, result.Count);
        }
    }
}