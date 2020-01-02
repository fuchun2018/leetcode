using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.ThreeSum
{
    public class MaximumPathSumSolution
    {
        public int MaxPathSum(TreeNode root)
        {
            if (root == null) return 0;
            int[] maxPath = new[] { int.MinValue };

            Dfs(root, maxPath);
            return maxPath[0];
        }

        private int Dfs(TreeNode node, int[] maxVal)
        {
            if (node == null)
            {
                return 0;
            }

            int left = Dfs(node.left, maxVal);
            int right = Dfs(node.right, maxVal);
            int myself = node.val + left + right;
            maxVal[0] = Math.Max(myself, maxVal[0]);
            return Math.Max(node.val + Math.Max(left, right), 0);
        }
    }
}
