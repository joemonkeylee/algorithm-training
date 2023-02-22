using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{

    //给你一个链表，两两交换其中相邻的节点，并返回交换后链表的头节点。你必须在不修改节点内部的值的情况下完成本题（即，只能进行节点交换）。

    //示例 1：
    //输入：head = [1,2,3,4]
    //输出：[2,1,4,3]

    //示例 2：
    //输入：head = []
    //输出：[]

    //示例 3：
    //输入：head = [1]
    //输出：[1]

    //提示：
    //链表中节点的数目在范围[0, 100] 内
    //0 <= Node.val <= 100

    internal class _24
    {
        //public ListNode swapPairs(ListNode head)
        //{
        //    if (head == null || head.next == null)
        //    {
        //        return head;
        //    }
        //    ListNode next = head.next;
        //    head.next = swapPairs(next.next);
        //    next.next = head;
        //    return next;
        //}

        public ListNode SwapPairs(ListNode head)
        {
            ListNode pre = new ListNode(0);
            pre.next = head;
            ListNode temp = pre;
            while (temp.next != null && temp.next.next != null)
            {
                ListNode start = temp.next;
                ListNode end = temp.next.next;
                temp.next = end;
                start.next = end.next;
                end.next = start;
                temp = start;
            }
            return pre.next;
        }

        //public ListNode SwapPairs(ListNode head)
        //{
        //    if (head == null)
        //    {
        //        return null;
        //    }

        //    ListNode res = new ListNode();
        //    int index = 0;

        //    Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();

        //    //奇数+1 偶数-1
        //    while (head != null)
        //    {
        //        index++;
        //        dict.Add(index + (index % 2 == 1 ? 1 : -1), head);
        //        head = head.next;
        //    }

        //    head = dict[1];
        //    for (int i = 1; i < dict.Keys.Count(); i++)
        //    {
        //        dict[i].next = dict[i + 1];
        //    }
        //    return head;
        //}
    }
}
