### 思路
1、判空直接返回
2、算总数 算实际需要移动低次数
3、如果没移动 直接返回
4、如果移动 将链表转为环 循环赋值 index从1开始少循环一次 多操作一次再循环外给返回赋值
5、断开环 返回结果


### 代码

```c#

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

```

**复杂度分析**
- 时间复杂度：O(n)
- 空间复杂度：O(1)