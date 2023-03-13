using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace DailyCheck.FormTools.Questions
{
    internal class _35
    {
        //给定一个排序数组和一个目标值，在数组中找到目标值，并返回其索引。如果目标值不存在于数组中，返回它将会被按顺序插入的位置。
        //请必须使用时间复杂度为 O(log n) 的算法。

        //示例 1:
        //输入: nums = [1,3,5,6], target = 5
        //输出: 2

        //示例 2:
        //输入: nums = [1,3,5,6], target = 2
        //输出: 1
        //示例 3:

        //输入: nums = [1,3,5,6], target = 7
        //输出: 4

        //提示:
        //1 <= nums.length <= 104
        //-104 <= nums[i] <= 104
        //nums 为 无重复元素 的 升序 排列数组
        //-104 <= target <= 104

        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {
                //设最左边下标为0，最右边下标为数组长度-1
                int low = 0, high = nums.Length - 1;
                //声明一个存储中间值的变量
                int mid = 0;
                //如果左小于等于右，持续循环
                while (low <= high)
                {
                    //求low到high的中间值；
                    mid = (high - low) / 2 + low;
                    //判断是否与target相等;
                    if (nums[mid] == target)
                    {
                        //找到则返回数组下标
                        return mid;
                    }
                    //如果判断中间值比target要小，那就证明target在中间值的右边
                    else if (nums[mid] < target)
                    {
                        //把high移动到中间值后一位，然后继续循环查找
                        low = mid + 1;
                    }
                    //如果判断中间值比target要大，那就证明target在中间值的左边
                    else
                    {
                        //把high移动到中间值前一位，然后继续循环查找
                        high = mid - 1;
                    }
                }

                //上面循环没有找到target，但中间值是最靠近target的数的。
                //判断相近数的大小，然后返回插入的下标
                if (target > nums[mid])
                {
                    return mid + 1;
                }
                else
                {
                    return mid;
                }
            }
        }


        //public int SearchInsert(int[] nums, int target)
        //{
        //    int start = 0;
        //    int end = nums.Length - 1;
        //    if (nums[nums.Length - 1] < target) return nums.Length;

        //    int middle = 0;
        //    while (start < end)
        //    {
        //        middle = getIndex(start, end);

        //        if (target == nums[middle])
        //        {
        //            return middle;
        //        }
        //        else if (target > nums[middle])
        //        {
        //            start = middle;
        //            end = nums.Length - 1;

        //        }
        //        else if (target < nums[middle])
        //        {
        //            start = 0;
        //            end = middle;
        //        }
        //    }
        //    return middle + 1;
        //}

        public int getIndex(int start, int end)
        {
            return start + (end - start) / 2;
        }
    }
}
