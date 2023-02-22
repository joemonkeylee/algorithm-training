﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    //给定一个单链表的头节点 head ，其中的元素 按升序排序 ，将其转换为高度平衡的二叉搜索树。
    //本题中，一个高度平衡二叉树是指一个二叉树每个节点 的左右两个子树的高度差不超过 1。

    //示例 1:
    //输入: head = [-10,-3,0,5,9]
    //输出: [0,-3,9,-10,null,5]
    //解释: 一个可能的答案是[0，-3, 9，-10, null, 5]，它表示所示的高度平衡的二叉搜索树。

    //示例 2:
    //输入: head = []
    //输出: []


    //提示:
    //head 中的节点数在[0, 2 104] 范围内
    //-105 <= Node.val <= 105

    internal class _109
    {

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

        public TreeNode SortedListToBST(ListNode head)
        {
            return CreateBST(head, null);
        }

        public TreeNode CreateBST(ListNode start, ListNode end)
        {
            if (start == end)
            {
                return null;
            }
            ListNode slow = start, fast = start.next;
            while (fast != end && fast.next != end)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return new TreeNode(slow.val, CreateBST(start, slow), CreateBST(slow.next, end));
        }

        //public TreeNode SortedListToBST(ListNode head)
        //{
        //    return CreateBST(head, null);
        //}

        //public TreeNode CreateBST(ListNode start, ListNode end)
        //{
        //    if (start == end)
        //    {
        //        return null;
        //    }
        //    ListNode slow = start, fast = start;
        //    while (fast != end && fast.next != end)
        //    {
        //        slow = slow.next;
        //        fast = fast.next.next;
        //    }
        //    return new TreeNode(slow.val, CreateBST(start, slow), CreateBST(slow.next, end));
        //}

        Random random = new Random();

        //public TreeNode SortedListToBST(ListNode head)
        //{
        //    return CreateBST(head, null);
        //}

        //public TreeNode CreateBST(ListNode start, ListNode end)
        //{
        //    if (start == end)
        //    {
        //        return null;
        //    }
        //    ListNode slow = start, fast = start.next;
        //    while (fast != end && fast.next != end)
        //    {
        //        slow = slow.next;
        //        fast = fast.next.next;
        //    }
        //    if (fast != end && random.Next(2) == 1)
        //    {
        //        slow = slow.next;
        //    }
        //    return new TreeNode(slow.val, CreateBST(start, slow), CreateBST(slow.next, end));
        //}
    }
}
