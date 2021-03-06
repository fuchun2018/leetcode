﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.DeleteNodeInLinkedList
{
    public class DeleteNodeSolution
    {
        public void DeleteNode(ListNode node)
        {
            if (node == null || node.next == null)
                return;

            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
