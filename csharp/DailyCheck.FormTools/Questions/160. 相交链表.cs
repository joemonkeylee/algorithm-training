using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _160
    {

        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x, ListNode node) { val = x; next = node; }
        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            ListNode pA = headA, pB = headB;
            while (pA != pB)
            {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;
        }

        //public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        //{
        //    if (headA == null && headB == null)
        //    {
        //        return null;
        //    }
        //    ListNode current = new ListNode(0, null);
        //    while (!(headA.next == null && current.next == null))
        //    {
        //        if (current.next == null)
        //        {
        //            current = headB;
        //        }

        //        if (headA.next == null)
        //        {
        //            headA = headA.next;
        //        }

        //        if (headA.val == current.val)
        //        {
        //            return current;
        //        }
        //        else
        //        {
        //            current = current.next;
        //        }
        //    }

        //    return null;
        //}
    }
}
