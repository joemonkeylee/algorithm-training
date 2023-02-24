using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DailyCheck.FormTools.Questions
{
    internal class _142
    {
        //给定一个链表的头节点 head ，返回链表开始入环的第一个节点。 如果链表无环，则返回 null。

        //如果链表中有某个节点，可以通过连续跟踪 next 指针再次到达，则链表中存在环。 为了表示给定链表中的环，评测系统内部使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。如果 pos 是 -1，则在该链表中没有环。注意：pos 不作为参数进行传递，仅仅是为了标识链表的实际情况。

        //不允许修改 链表。

        //示例 1：
        //输入：head = [3,2,0,-4], pos = 1
        //输出：返回索引为 1 的链表节点
        //解释：链表中有一个环，其尾部连接到第二个节点。

        //示例 2：
        //            输入：head = [1,2], pos = 0
        //输出：返回索引为 0 的链表节点
        //解释：链表中有一个环，其尾部连接到第一个节点。

        //示例 3：
        //输入：head = [1], pos = -1
        //输出：返回 null
        //解释：链表中没有环。


        //提示：
        //链表中节点的数目范围在范围[0, 104] 内
        //-105 <= Node.val <= 105
        //pos 的值为 -1 或者链表中的一个有效索引

        //        口头解释就是
        //快针走的是慢针的两倍。
        //慢针走过的路，快针走过一遍。
        //快针走过的剩余路程，也就是和慢针走过的全部路程相等。(a+b = c+b)
        //刨去快针追赶慢针的半圈(b)，剩余路程即为所求入环距离(a= c)
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }

        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;
            ListNode fast = head;//快指针
            ListNode slow = head;//慢指针
            ListNode temp = head;//辅助指针

            while (fast != null)//快指针不为null
            {
                slow = slow.next;
                if (fast.next == null) return null;//快指针当前节点和next节点都不为null，才可以走两步
                fast = fast.next.next;
                if (slow == fast)//相遇了，说明有环
                {
                    while (temp != slow)//开始找入环节点
                    {
                        temp = temp.next;
                        slow = slow.next;
                    }
                    return temp; //找到入环节点输出  
                }
            }
            return null;
        }


        //官方
        //public ListNode DetectCycle(ListNode head)
        //{
        //    ListNode fast = head;
        //    ListNode slow = head;
        //    while (fast != null && fast.next != null)
        //    {
        //        slow = slow.next;
        //        fast = fast.next.next;
        //        while (fast == slow)
        //        {
        //            ListNode index1 = head;
        //            ListNode index2 = fast;
        //            while (index1 != index2)
        //            {
        //                index1 = index1.next;
        //                index2 = index2.next;
        //            }
        //            return index2;
        //        }
        //    }
        //    return null;
        //}

        //这种不对
        //public ListNode DetectCycle(ListNode head)
        //{
        //    // 如果头节点为空，直接返回false
        //    if (head == null)
        //    {
        //        return null;
        //    }
        //    // 定义快慢指针，初始化为头节点
        //    ListNode fast = head;
        //    ListNode slow = head;
        //    // 用一个循环来移动快慢指针
        //    while (fast != null && fast.next != null)
        //    {
        //        // 快指针每次移动两个节点
        //        fast = fast.next.next;
        //        // 慢指针每次移动一个节点
        //        slow = slow.next;
        //        // 如果快慢指针相遇了，说明有环，返回true
        //        if (fast == slow)
        //        {
        //            return fast;
        //        }
        //    }
        //    // 如果快指针移动到了null，说明没有环，返回false
        //    return null;
        //}
    }
}
