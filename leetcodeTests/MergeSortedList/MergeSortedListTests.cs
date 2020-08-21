using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetcode;
using leetcode.MergeKSortedLists;
using leetcode.MergeTwoSortedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcodeTests.MergeSortedList
{
    [TestClass]
    public class MergeSortedListTests
    {
        [TestMethod]
        public void Test()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);

            MergeTwoSortedListSolution s = new MergeTwoSortedListSolution();
            var result = s.MergeTwoLists(l1, l2);

        }

        [TestMethod]
        public void Test2()
        {
            var listArray = new ListNode[3];

            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(4);
            listArray[0] = l1;

            ListNode l2 = new ListNode(1);
            l2.next = new ListNode(3);
            l2.next.next = new ListNode(4);
            listArray[1] = l2;


            ListNode l3 = new ListNode(1);
            l3.next = new ListNode(5);
            l3.next.next = new ListNode(6);
            listArray[2] = l3;

            MergeKSortedListsSolution s = new MergeKSortedListsSolution();
            s.MergeKLists(listArray);
        }
    }
}
