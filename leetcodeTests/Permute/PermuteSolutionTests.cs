using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.Permute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Permute.Tests
{
    [TestClass()]
    public class PermuteSolutionTests
    {
        [TestMethod()]
        public void PermuteTest()
        {
            var solution = new PermuteSolution();
            var result = solution.Permute(new int[] { 1 });
            Assert.IsNotNull(result);
        }
    }
}