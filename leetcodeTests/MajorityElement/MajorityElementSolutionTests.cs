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
            Assert.AreEqual(new MajorityElementSolution().MajorityElement(new int[] { 3, 2, 3 ,3,3,3,3,4,4,2,1,4,5,3,3,0}), 3);
        }
    }
}