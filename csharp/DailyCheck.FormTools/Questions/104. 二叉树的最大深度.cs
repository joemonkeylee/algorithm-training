using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _104
    {
        //给定一个二叉树，找出其最大深度。

        //二叉树的深度为根节点到最远叶子节点的最长路径上的节点数。

        //说明: 叶子节点是指没有子节点的节点。

        //示例：
        //给定二叉树[3, 9, 20, null, null, 15, 7]，

        //    3
        //   / \
        //  9  20
        //    /  \
        //   15   7
        //返回它的最大深度 3 。

        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }


        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int leftDepth = MaxDepth(root.left);
                int rightDepth = MaxDepth(root.right);
                return Math.Max(leftDepth, rightDepth) + 1;
            }
        }
    }
}
