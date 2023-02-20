using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _61
    {
    }

    //* Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
            {
                return head;
            }

            int n = 1;
            ListNode end = head;
            while (end.next != null)
            {
                end = end.next;
                n++;
            }
            k %= n;
            if (k == 0)
            {
                return head;
            }

            end.next = head;//链表变成环

            int newTailIndex = n - k;
            ListNode ans = head;
            //少循环一次后面多走一次赋值
            for (int i = 1; i < newTailIndex; i++)
            {
                ans = ans.next;
            }
            ListNode newHead = ans.next;
            ans.next = null;//还原回链表
            return newHead;
        }
    }
}
