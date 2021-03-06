﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ReverseLinkedList
{
    public class ReverseListSolution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || (head.next == null)) return head;
            var result = head;
            var cursor = result.next;
            result.next = null;
            while (cursor != null)
            {
                var temp = cursor.next;
                cursor.next = result;
                result = cursor;
                cursor = temp;
            }
            return result;
        }
    }
}
