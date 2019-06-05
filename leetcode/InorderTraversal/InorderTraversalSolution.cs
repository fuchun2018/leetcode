using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.InorderTraversal
{
    public class InorderTraversalSolution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cursor = root;
            while (cursor != null || stack.Count > 0)
            {
                while (cursor != null)
                {
                    stack.Push(cursor);
                    cursor = cursor.left;
                }
                cursor = stack.Pop();
                result.Add(cursor.val);
                cursor = cursor.right;
            }
            return result;
        }
    }
}
