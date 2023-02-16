﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    //请你设计一个支持对其元素进行增量操作的栈。

    //实现自定义栈类 CustomStack ：

    //CustomStack(int maxSize)：用 maxSize 初始化对象，maxSize 是栈中最多能容纳的元素数量。
    //void push(int x)：如果栈还未增长到 maxSize ，就将 x 添加到栈顶。
    //int pop()：弹出栈顶元素，并返回栈顶的值，或栈为空时返回 -1 。
    //void inc(int k, int val)：栈底的 k 个元素的值都增加 val 。如果栈中元素总数小于 k ，则栈中的所有元素都增加 val 。


    //示例：

    //输入：
    //["CustomStack","push","push","pop","push","push","push","increment","increment","pop","pop","pop","pop"]
    //[[3],[1],[2],[],[2],[3],[4],[5,100],[2,100],[],[],[],[]]
    //输出：
    //[null,null,null,2,null,null,null,null,null,103,202,201,-1]
    //解释：
    //CustomStack stk = new CustomStack(3); // 栈是空的 []
    //stk.push(1);                          // 栈变为 [1]
    //stk.push(2);                          // 栈变为 [1, 2]
    //stk.pop();                            // 返回 2 --> 返回栈顶值 2，栈变为 [1]
    //stk.push(2);                          // 栈变为 [1, 2]
    //stk.push(3);                          // 栈变为 [1, 2, 3]
    //stk.push(4);                          // 栈仍然是 [1, 2, 3]，不能添加其他元素使栈大小变为 4
    //stk.increment(5, 100);                // 栈变为 [101, 102, 103]
    //stk.increment(2, 100);                // 栈变为 [201, 202, 103]
    //stk.pop();                            // 返回 103 --> 返回栈顶值 103，栈变为 [201, 202]
    //stk.pop();                            // 返回 202 --> 返回栈顶值 202，栈变为 [201]
    //stk.pop();                            // 返回 201 --> 返回栈顶值 201，栈变为 []
    //stk.pop();                            // 返回 -1 --> 栈为空，返回 -1


    //提示：

    //1 <= maxSize, x, k <= 1000
    //0 <= val <= 100
    //每种方法 increment，push 以及 pop 分别最多调用 1000 次
    internal class _1381
    {
    }

    //CustomStack stk = new CustomStack(3); // 栈是空的 []
    //stk.push(1);                          // 栈变为 [1]
    //stk.push(2);                          // 栈变为 [1, 2]
    //stk.pop();                            // 返回 2 --> 返回栈顶值 2，栈变为 [1]
    //stk.push(2);                          // 栈变为 [1, 2]
    //stk.push(3);                          // 栈变为 [1, 2, 3]
    //stk.push(4);                          // 栈仍然是 [1, 2, 3]，不能添加其他元素使栈大小变为 4
    //stk.increment(5, 100);                // 栈变为 [101, 102, 103]
    //stk.increment(2, 100);                // 栈变为 [201, 202, 103]
    //stk.pop();                            // 返回 103 --> 返回栈顶值 103，栈变为 [201, 202]
    //stk.pop();                            // 返回 202 --> 返回栈顶值 202，栈变为 [201]
    //stk.pop();                            // 返回 201 --> 返回栈顶值 201，栈变为 []
    //stk.pop();                            // 返回 -1 --> 栈为空，返回 -1

    public class CustomStack
    {
        int[] array;
        int index = -1;
        public CustomStack(int maxSize)
        {
            array = new int[maxSize];
        }

        public void Push(int x)
        {
            if (index < array.Length - 1)
            {
                array[++index] = x;
            }
        }

        public int Pop()
        {
            return index < 0 ? -1 : array[index--];
        }

        public void Increment(int k, int val)
        {
            for (int i = 0; i < (k > array.Length ? array.Length : k); i++)
            {
                array[i] += val;
            }
        }
    }

    ///stack[index]= 不能赋值 所以没办法用stack
    //public class CustomStack
    //{
    //    private Stack<int> stack;
    //    public int size { get; set; }
    //    public CustomStack(int maxSize)
    //    {
    //        size = maxSize;
    //        stack = new Stack<int>(maxSize);
    //    }

    //    public void Push(int x)
    //    {
    //        if (stack.Count() < size)
    //        {
    //            stack.Push(x);
    //        }
    //    }

    //    public int Pop()
    //    {
    //        if (stack.Count() == 0)
    //        {
    //            return stack.Pop();
    //        }
    //        else
    //        {
    //            return 0;
    //        }

    //    }

    //    public void Increment(int k, int val)
    //    {
    //        if (stack.Count > 0)
    //        {
    //            var res = stack.ToArray();
    //            for (int i = 0; i < stack.Count; i++)
    //            {
    //                res[i] += val;
    //            }
    //        }
    //    }
    //}
}
