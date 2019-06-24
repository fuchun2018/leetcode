using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetcode.ReverseLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ReverseLinkedList.Tests
{
    [TestClass()]
    public class ReverseListSolutionTests
    {
        [TestMethod()]
        public void ReverseListTest()
        {
            var node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(3);
            node.next.next.next = new ListNode(4);
            node.next.next.next.next = new ListNode(5);
            var solution = new ReverseListSolution();
            var result = solution.ReverseList(node);
            Assert.IsNotNull(result);
        }
    }
}