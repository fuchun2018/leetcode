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
    }
}