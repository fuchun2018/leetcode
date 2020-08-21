using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.PalindromeLinkedList
{
    public class PalindromeLinkedListSolution
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head?.next == null)
                return true;

            var slow = head;
            var fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            var reverseNode = reverseListNode(slow.next);
            slow.next = null;
            var point = head;
            
            while (reverseNode != null)
            {
                if (point.val != reverseNode.val)
                {
                    return false;
                }
                point = point.next;
                reverseNode = reverseNode.next;
            }
            return true;
        }

        private ListNode reverseListNode(ListNode head)
        {
            var point = head;
            ListNode result = null;
            while (point != null)
            {
                var newNode = new ListNode(point.val) {next = result};
                result = newNode;
                point = point.next;
            }
            return result;
        }
    }
}
