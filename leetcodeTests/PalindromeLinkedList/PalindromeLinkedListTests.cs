using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode;
using leetcode.PalindromeLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodeTests.PalindromeLinkedList
{
    [TestClass]
    public class PalindromeLinkedListTests
    {
        [TestMethod]
        public void Test()
        {

            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);
            l1.next.next.next.next.next = new ListNode(6);

            var solution = new PalindromeLinkedListSolution().IsPalindrome(l1);
            Assert.IsFalse(solution);
        }

        [TestMethod]
        public void Test2()
        {

            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(2);
            l1.next.next.next.next = new ListNode(1);
            //l1.next.next.next.next.next = new ListNode(6);

            var solution = new PalindromeLinkedListSolution().IsPalindrome(l1);
            Assert.IsTrue(solution);
        }
    }
}
