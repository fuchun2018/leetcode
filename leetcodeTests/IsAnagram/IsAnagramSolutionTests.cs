using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.IsAnagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.IsAnagram.Tests
{
    [TestClass()]
    public class IsAnagramSolutionTests
    {
        [TestMethod()]
        public void IsAnagramTest()
        {
            Assert.IsTrue(new IsAnagramSolution().IsAnagram("anagram", "nagaram"));
        }
    }
}