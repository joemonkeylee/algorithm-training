using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _239
    {
        //给你一个整数数组 nums，有一个大小为 k 的滑动窗口从数组的最左侧移动到数组的最右侧。你只可以看到在滑动窗口内的 k 个数字。滑动窗口每次只向右移动一位。
        //返回 滑动窗口中的最大值 。

        //示例 1：
        //输入：nums = [1,3,-1,-3,5,3,6,7], k = 3
        //输出：[3,3,5,5,6,7]
        //解释：
        //滑动窗口的位置 最大值
        //---------------               -----
        //[1  3  -1] -3  5  3  6  7       3
        //1 [3  -1  -3] 5  3  6  7       3
        //1  3 [-1  -3  5] 3  6  7       5
        //1  3  -1 [-3  5  3] 6  7       5
        //1  3  -1  -3 [5  3  6] 7       6
        //1  3  -1  -3  5 [3  6  7]      7

        //示例 2：
        //输入：nums = [1], k = 1
        //输出：[1]

        //提示：
        //1 <= nums.Length <= 105
        //-104 <= nums[i] <= 104
        //1 <= k <= nums.Length

        //输入 [1,3,-1,-3,5,3,6,7] 3
        //输出 [3,3,5,5,6,7]


        public int[] MaxSlidingWindow(int[] nums, int k)
        {
            int n = nums.Length;
            int[] res = new int[n - k + 1];
            LinkedList<int> dq = new LinkedList<int>();
            for (int i = 0; i < n; i++)
            {
                if (dq.Count != 0 && dq.First.Value < (i - k + 1))
                {
                    dq.RemoveFirst();//超出窗口长度时删除队首
                }
                while (dq.Count != 0 && nums[i] >= nums[dq.Last.Value])
                {
                    dq.RemoveLast();//如果遍历的元素大于队尾元素就删除队尾
                }
                dq.AddLast(i);//添加
                if (i >= k - 1)
                {
                    res[i - k + 1] = nums[dq.First.Value];//结果
                }
            }
            return res;
        }

        //有case不过
        //public int[] MaxSlidingWindow(int[] nums, int k)
        //{
        //    //用双端队列来存储数组的下标，为什么要存下标而不是存数值？
        //    //因为存下标可以更方便的来确定元素是否需要移出滑动窗口
        //    //判断下标是否合法来确定是否要移出
        //    Queue<int> q = new Queue<int>();
        //    //搞不清res的size就举个例子来确定
        //    int[] res = new int[nums.Length - k + 1];
        //    int index = 0;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        //保证队列的单调递减，使队列的出口始终为最大值
        //        //注意队列存的是数组下标，所以判断逻辑是nums[i] > nums[q.peekLast()]
        //        //容易误写成nums[i] > q.peekLast()
        //        while (q.Count > 0 && nums[i] > nums[q.Peek()])
        //        {
        //            q.Dequeue();
        //        }
        //        q.Enqueue(i);
        //        //判断队列出口的值是否合法，如果值的下标不在窗口内则要将其移出
        //        if (q.Peek() < i - k + 1)
        //        {
        //            q.Dequeue();
        //        }
        //        //窗口至少填满一次后才开始放最大值
        //        //依然要注意队列存的是下标，所以赋值是赋nums[q.peekFirst()]
        //        if (i >= k - 1)
        //        {
        //            res[index++] = nums[q.FirstOrDefault()];
        //        }

        //    }
        //    return res;
        //}
        //    public int[] MaxSlidingWindow(int[] nums, int k)
        //    {
        //        if (nums == null || nums.Length < 2)
        //        {
        //            return nums;
        //        }
        //        // 双端队列 保存当前窗口最大值的数组位置 保证队列中数组位置的数值按从大到小排序
        //        Queue<int> que = new Queue<int>();

        //        int[] result = new int[nums.Length - k + 1];

        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            // 保证从大到小 如果前面数小则需要依次弹出，直至满足要求
        //            while (que.Count() > 0 && nums[que.Peek()] <= nums[i])
        //            {
        //                que.Dequeue();
        //            }
        //            // 添加当前值对应的数组下标
        //            que.Enqueue(i);

        //            // 判断当前队列中队首的值是否有效
        //            if (que.Peek() <= i - k)
        //            {
        //                que.Dequeue();
        //            }
        //            // 当窗口长度为k时 保存当前窗口中最大值
        //            if (i + 1 >= k)
        //            {
        //                result[i + 1 - k] = nums[que.LastOrDefault()];
        //            }
        //        }
        //        return result;
        //    }
        //}


        ////超时
        //public int[] MaxSlidingWindow(int[] nums, int k)
        //{
        //    int[] result = new int[nums.Length - k + 1];
        //    for (int i = 0; i < nums.Length - k + 1; i++)
        //    {
        //        result[i] = nums.Skip(i).Take(k).Max();
        //    }
        //    return result;
        //}
    }
}
