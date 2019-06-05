using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.InorderTraversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.InorderTraversal.Tests
{
    [TestClass()]
    public class InorderTraversalSolutionTests
    {
        [TestMethod()]
        public void InorderTraversalTest()
        {
            var input = new TreeNode(1);
            input.right = new TreeNode(2);
            input.right.left = new TreeNode(3);

            var expect = new List<int>
            {
                1, 3, 2
            };
            Assert.AreEqual(expect, new InorderTraversalSolution().InorderTraversal(input));
        }
    }
}