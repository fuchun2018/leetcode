using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.ReverseString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ReverseString.Tests
{
    [TestClass()]
    public class ReverseStringSolutionTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            var solution = new ReverseStringSolution();
            solution.ReverseString("hello".ToCharArray());
        }
    }
}