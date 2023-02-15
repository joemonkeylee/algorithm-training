using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    // 给你一个非空数组，返回此数组中 第三大的数 。如果不存在，则返回数组中最大的数。
    //示例 1：

    //输入：[3, 2, 1]
    //输出：1
    //解释：第三大的数是 1 。
    //示例 2：

    //输入：[1, 2]
    //输出：2
    //解释：第三大的数不存在, 所以返回最大的数 2 。
    //示例 3：

    //输入：[2, 2, 3, 1]
    //输出：1
    //解释：注意，要求返回第三大的数，是指在所有不同数字中排第三大的数。
    //此例中存在两个值为 2 的数，它们都排第二。在所有不同数字中排第三大的数为 1 。


    //提示：
    //1 <= nums.length <= 104
    //-231 <= nums[i] <= 231 - 1

    internal class _414
    {
        /// <summary>
        /// 5 3 1  4 ->6>3 6>5 替换左边 中间向右 5 4 3
        /// 5 3 1  4 ->4>3 4<5 替换中间 中间向右 5 4 3
        /// 5 3 1  4 ->2<3 2>1 替换右
        public int ThirdMax(int[] nums)
        {
            int[] flags = new int[3] { nums[0], nums[0], nums[0] };
            for (int i = 0; i < nums.Count(); i++)
            {
                if ((nums[i] != flags[0]) && (nums[i] != flags[1]) && (nums[i] != flags[2]) && (nums[i] > flags[2]))
                {
                    if (nums[i] > flags[0])
                    {
                        flags[2] = flags[1];
                        flags[1] = flags[0];
                        flags[0] = nums[i];
                    }
                    else if (nums[i] > flags[1])
                    {
                        flags[2] = flags[1];
                        flags[1] = nums[i];
                    }
                    else if (nums[i] > flags[2])
                    {
                        flags[2] = nums[i];
                    }
                }
            }

            if (flags.Count(x => x != null) >= 3)
            {
                return flags[2];
            }
            else
            {
                return flags[0];
            }
        }

        ///// </summary>
        ///// <param name="nums">思考得来 不要使用可空类型 这个没办法处理了 错误</param>
        ///// <returns></returns>
        //public int ThirdMax(int[] nums)
        //{
        //    int? intTemp = null;
        //    //较大值在左
        //    int?[] flags = new int?[3] { intTemp, intTemp, intTemp };
        //    for (int i = 0; i < nums.Count(); i++)
        //    {
        //        if ((nums[i] != flags[0]) && (nums[i] != flags[1]) && (nums[i] != flags[2]))
        //        {
        //            if (nums[i] > flags[0])
        //            {
        //                flags[2] = flags[1];
        //                flags[1] = flags[0];
        //                flags[0] = nums[i];
        //            }
        //            else if (nums[i] > flags[1])
        //            {
        //                flags[2] = flags[1];
        //                flags[1] = nums[i];
        //            }
        //            else if (nums[i] > flags[2])
        //            {
        //                flags[2] = nums[i];
        //            }
        //        }
        //    }

        //    if (flags.Count(x => x != null) >= 3)
        //    {
        //        return flags[2].Value;
        //    }
        //    else
        //    {
        //        return flags[0].Value;
        //    }
        //}


        //执行用时：88 ms, 在所有 C# 提交中击败了59.70%的用户
        //内存消耗：39 MB, 在所有 C# 提交中击败了34.33%的用户
        //public int ThirdMax(int[] nums)
        //{
        //    List<int> list = new List<int>();
        //    for (int i = 0; i < nums.Count(); i++)
        //    {
        //        if (!list.Contains(nums[i]))
        //        {
        //            list.Add(nums[i]);
        //        }
        //    }
        //    return list.OrderByDescending(x => x).ElementAt(list.Count() >= 3 ? 2 : 0);
        //}

        //执行用时：84 ms, 在所有 C# 提交中击败了83.58%的用户
        //内存消耗：39.6 MB, 在所有 C# 提交中击败了5.97%的用户
        //public int ThirdMax(int[] nums)
        //{
        //    HashSet<int> set = new HashSet<int>();
        //    for (int i = 0; i < nums.Count(); i++)
        //    {
        //        set.Add(nums[i]);
        //    }
        //    return set.OrderByDescending(x => x).ElementAt(set.Count() >= 3 ? 2 : 0);
        //}

        //执行用时：116 ms, 在所有 C# 提交中击败了5.97%的用户
        //内存消耗：49.7 MB, 在所有 C# 提交中击败了5.97%的用户
        //public int ThirdMax(int[] nums)
        //{
        //    var groups = nums.OrderByDescending(x => x).GroupBy(x => x);
        //    var maxCount = 3;
        //    for (int i = 0; i < groups.Count(); i++)
        //    {
        //        if (maxCount > 0)
        //        {
        //            maxCount--;
        //        }
        //        else
        //        {
        //            return groups.ElementAt(2).Key;
        //        }
        //    }

        //    if (maxCount >= groups.Count())
        //    {
        //        return groups.ElementAt(groups.Count() - 1).Key;
        //    }

        //    if (maxCount >= 0)
        //    {
        //        return groups.ElementAt(groups.Count() - 1 - maxCount).Key;
        //    }
        //    return 0;
        //}
    }
}
