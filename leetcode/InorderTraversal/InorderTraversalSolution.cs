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
            if (root == null) return null;
            if (root.left == null && root.right == null) return new List<int> { root.val };
            var result = new List<int>();
            if (root.left != null) result.AddRange(InorderTraversal(root.left));
            result.Add(root.val);
            if (root.right != null) result.AddRange(InorderTraversal(root.right));
            return result;
        }
    }
}
