using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode.ZigzagConversion;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodeTests.ZigzagConvertion
{
    [TestClass]
    public class ZigZagConversionTests
    {
        [TestMethod]
        public void Test()
        {
            var zigzag = new ZigzagConversionSolution();
            var result = zigzag.Convert("PAYPALISHIRING", 4);
            Assert.AreEqual("PINALSIGYAHRPI", result);
        }
    }
}
