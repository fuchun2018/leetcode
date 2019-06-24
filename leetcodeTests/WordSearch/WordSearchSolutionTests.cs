using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.WordSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Assert.AreEqual(0,result.Count() );
        }
    }
}