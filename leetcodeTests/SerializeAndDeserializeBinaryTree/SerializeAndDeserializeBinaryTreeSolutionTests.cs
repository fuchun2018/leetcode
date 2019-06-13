using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.SerializeAndDeserializeBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.SerializeAndDeserializeBinaryTree.Tests
{
    [TestClass()]
    public class SerializeAndDeserializeBinaryTreeSolutionTests
    {
        [TestMethod()]
        public void serializeTest()
        {
            var solution = new SerializeAndDeserializeBinaryTreeSolution();
            var treeNode = new TreeNode(1);
            treeNode.left = new TreeNode(2);
            treeNode.right = new TreeNode(3);
            var result = solution.serialize(treeNode);
            var expect = "1,2,,,3,,,";
            Assert.AreEqual(expect, result);
        }
    }
}