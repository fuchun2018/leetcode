using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.MajorityElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.MajorityElement.Tests
{
    [TestClass()]
    public class MajorityElementSolutionTests
    {
        [TestMethod()]
        public void MajorityElementTest()
        {
            Assert.AreEqual(new MajorityElementSolution().MajorityElement(new int[] { 6, 5, 5}), 5);
        }
    }
}