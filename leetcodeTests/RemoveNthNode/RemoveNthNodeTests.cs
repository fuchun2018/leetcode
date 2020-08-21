using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using leetcode;
using leetcode.RemoveNthNode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodeTests.RemoveNthNode
{
    [TestClass]
    public class RemoveNthNodeTests
    {
        [TestMethod]
        public void Test()
        {
            var header = new ListNode(1);
            var next = new ListNode(2);
            header.next = next;
            var removed = new RemoveNthNodeSolution();
            removed.RemoveNthFromEnd(header, 2);
        }

        //[1,2,3,4,5]
        [TestMethod]
        public void Test2()
        {
            var header = new ListNode(1);
            var point = header;
            point.next = new ListNode(2);
            point = point.next;
            point.next= new ListNode(3);
            point = point.next;
            point.next = new ListNode(4);
            point = point.next;
            point.next = new ListNode(5);
            new RemoveNthNodeSolution().RemoveNthFromEnd(header, 2);
        }
    }
}
