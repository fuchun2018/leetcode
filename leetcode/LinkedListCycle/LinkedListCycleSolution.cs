using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LinkedListCycle
{
    public class LinkedListCycleSolution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            var slow = head;
            var fast = head.next;

            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;

                fast = fast.next.next;
                slow = slow.next;
            }
            return true;
        }
    }
}
