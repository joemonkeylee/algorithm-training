### 思路

不能开辟辅助空间 会超时。艹了 递归没写出来。

### 代码

```c#
  
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

```

**复杂度分析**
- 时间复杂度：O(n)
- 空间复杂度：O(n)