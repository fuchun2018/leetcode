using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.DeleteNodeInLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.DeleteNodeInLinkedList.Tests
{
    [TestClass()]
    public class DeleteNodeSolutionTests
    {
        [TestMethod()]
        public void DeleteNodeTest()
        {
            new DeleteNodeSolution().DeleteNode(new ListNode(1));
        }
    }
}