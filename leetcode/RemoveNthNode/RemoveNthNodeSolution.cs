using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.RemoveNthNode
{
    public class RemoveNthNodeSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (n == 0)
            {
                return head;
            }
            if (n == 1 && head.next == null)
            {
                return null;
            }
            var counter = 0;
            var pointer = head;

            var dummy = new ListNode(-1) {next = head};
            while (pointer != null)
            {
                counter++;
                pointer = pointer.next;
            }

            var node = dummy;
            while (counter != n)
            {
                counter--;
                node = node.next;
            }

            node.next = node.next.next;
            return dummy.next;
        }
    }
} 