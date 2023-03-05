using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _347
    {
        //给你一个整数数组 nums 和一个整数 k ，请你返回其中出现频率前 k 高的元素。你可以按 任意顺序 返回答案。

        //示例 1:
        //输入: nums = [1,1,1,2,2,3], k = 2
        //输出: [1,2]

        //示例 2:
        //输入: nums = [1], k = 1
        //输出: [1]

        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.Keys.Contains(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
            }
            return dict.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        }
    }
}
