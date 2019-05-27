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
            var result = solution.IsMatch(string.Empty, string.Empty);
            Assert.IsFalse(result);
        }
    }
}