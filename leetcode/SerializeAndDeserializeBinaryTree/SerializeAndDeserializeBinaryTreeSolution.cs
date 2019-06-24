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
            if (string.IsNullOrEmpty(data) || (data == ",")) return null;
            var node = new Queue<string>(data.Split(','));
            var result = BinaryTreeRebuild(node);
            return result;
        }

        private TreeNode BinaryTreeRebuild(Queue<string> queue)
        {
            if((queue == null) || queue.Count == 0) return null;
            var element = queue.Dequeue();
            if (element == "") return null;
            var node = new TreeNode(int.Parse(element))
            {
                left = BinaryTreeRebuild(queue),
                right = BinaryTreeRebuild(queue)
            };
            return node;
        }
    }
}
