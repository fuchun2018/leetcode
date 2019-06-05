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

        [TestMethod()]
        public void InorderTraversalTest_Case_2()
        {
            var input = new TreeNode(1);
            input.left = new TreeNode(2);
            input.right = new TreeNode(3);
            input.left.left = new TreeNode(5);
            input.right.left = new TreeNode(4);
            input.right.right = new TreeNode(6);

            var expect = new List<int>
            {
                5, 2, 1, 4, 3, 6
            };
            Assert.AreEqual(expect, new InorderTraversalSolution().InorderTraversal(input));
        }
    }
}