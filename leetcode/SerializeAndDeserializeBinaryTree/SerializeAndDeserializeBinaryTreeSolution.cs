using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.SerializeAndDeserializeBinaryTree
{
    public class SerializeAndDeserializeBinaryTreeSolution
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null) return string.Empty + ",";
            return root.val + "," + serialize(root.left) + serialize(root.right);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            return null;
        }
    }
}
