using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.MergeTwoSortedList
{
    public class MergeTwoSortedListSolution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null)
                return l1 ?? l2;
            var point1 = l1;
            var point2 = l2;
            ListNode result = new ListNode(-1);
            ListNode p3 = result;
            while (l1 != null && l2 != null)
            {
                p3.next = new ListNode(l1.val > l2.val ? l2.val : l1.val);
                p3 = p3.next;
                if (l2.val <= l1.val)
                    l2 = l2.next;
                else
                    l1 = l1.next;
            }

            p3.next = l1 ?? l2;
            
            return result.next;
        }
    }
}
