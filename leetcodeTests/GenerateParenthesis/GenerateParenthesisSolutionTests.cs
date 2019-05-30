using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.GenerateParenthesis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.GenerateParenthesis.Tests
{
    [TestClass()]
    public class GenerateParenthesisSolutionTests
    {
        [TestMethod()]
        public void GenerateParenthesisTest()
        {
            var solution = new GenerateParenthesisSolution();
            var result = solution.GenerateParenthesis(5);
            Assert.IsNotNull(result);
        }
    }
}