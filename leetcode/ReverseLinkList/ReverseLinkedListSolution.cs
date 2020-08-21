using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ReverseLinkList
{
    public class ReverseLinkedListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head?.next == null) return head;
            ListNode result = null;
            var point = head;

            while (point != null)
            {
                var node = new ListNode(point.val);
                node.next = result;
                result = node;
                point = point.next;
            }

            return result;
        }
    }
}
