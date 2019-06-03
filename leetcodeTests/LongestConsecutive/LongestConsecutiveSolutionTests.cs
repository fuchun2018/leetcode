using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.LongestConsecutive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LongestConsecutive.Tests
{
    [TestClass()]
    public class LongestConsecutiveSolutionTests
    {
        [TestMethod()]
        public void LongestConsecutiveTest()
        {
            Assert.AreEqual(new LongestConsecutiveSolution().LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 }), 4);
        }
    }
}