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

        [TestMethod()]
        public void serializeTest_Case2()
        {
            var solution = new SerializeAndDeserializeBinaryTreeSolution();
            var treeNode = new TreeNode(1);
            var result = solution.serialize(treeNode);
            var expect = "1,,,";
            Assert.AreEqual(expect, result);
        }


        [TestMethod()]
        public void serializeTest_Case3()
        {
            var solution = new SerializeAndDeserializeBinaryTreeSolution();
            var result = solution.serialize(null);
            var expect = ",";
            Assert.AreEqual(expect, result);
        }

        [TestMethod()]
        public void deserializeTest()
        {
            var solution = new SerializeAndDeserializeBinaryTreeSolution();
            var input = "1,2,,,3,,,";
            var result = solution.deserialize(input);
            Assert.IsNotNull(result);
        }
    }
}