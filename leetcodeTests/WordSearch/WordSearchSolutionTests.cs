using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace leetcode.WordSearch.Tests
{
    [TestClass()]
    public class WordSearchSolutionTests
    {
        [TestMethod()]
        public void FindWordsTest()
        {
            var solution = new WordSearchSolution();
            var input = new char[][] { };
            var sw = new string[] { };
            var result = solution.FindWords(input, sw);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod()]
        public void FindWordsTest_Case2()
        {
            var solution = new WordSearchSolution();
            var input = new[] { new[] { 's', 'e' }, new[] { 'r', 'a' } };
            var sw = new[] { "sea", "ear" };
            var result = solution.FindWords(input, sw);
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod()]
        public void FindWordsTest_Case3()
        {
            var solution = new WordSearchSolution();
            var input = new[] { new[] { 'a' } };
            var sw = new[] { "a" };
            var result = solution.FindWords(input, sw);
            Assert.AreEqual(1, result.Count());
        }
        [TestMethod()]
        public void FindWordsTest_Case4()
        {
            var solution = new WordSearchSolution();
            var input = new[] { new[] { 'o', 'a', 'a', 'n' }, new[] { 'e', 't', 'a', 'e' }, new[] { 'i', 'h', 'k', 'r' }, new[] { 'i', 'f', 'l', 'v' } };
            var sw = new[] { "oath", "pea", "eat", "rain" };
            var result = solution.FindWords(input, sw);
            Assert.AreEqual(2, result.Count());
        }
    }
}