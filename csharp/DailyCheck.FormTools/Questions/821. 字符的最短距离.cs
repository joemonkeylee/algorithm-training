using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _821
    {
        //给你一个字符串 s 和一个字符 c ，且 c 是 s 中出现过的字符。
        //返回一个整数数组 answer ，其中 answer.length == s.length 且 answer[i] 是 s 中从下标 i 到离它 最近 的字符 c 的 距离 。
        //两个下标 i 和 j 之间的 距离 为 abs(i - j) ，其中 abs 是绝对值函数。

        //示例 1：
        //输入：s = "loveleetcode", c = "e"
        //输出：[3,2,1,0,1,0,0,1,2,2,1,0]
        //解释：字符 'e' 出现在下标 3、5、6 和 11 处（下标从 0 开始计数）。
        //距下标 0 最近的 'e' 出现在下标 3 ，所以距离为 abs(0 - 3) = 3 。
        //距下标 1 最近的 'e' 出现在下标 3 ，所以距离为 abs(1 - 3) = 2 。
        //对于下标 4 ，出现在下标 3 和下标 5 处的 'e' 都离它最近，但距离是一样的 abs(4 - 3) == abs(4 - 5) = 1 。
        //距下标 8 最近的 'e' 出现在下标 6 ，所以距离为 abs(8 - 6) = 2 。

        //示例 2：
        //输入：s = "aaab", c = "b"
        //输出：[3,2,1,0]

        //提示：
        //1 <= s.length <= 104
        //s[i] 和 c 均为小写英文字母
        //题目数据保证 c 在 s 中至少出现一次



        //public int[] ShortestToChar(string s, char c)
        //{
         
        //}


        /// <summary>
        /// my solve
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public int[] ShortestToChar(string s, char c)
        {
            //记录c的位置
            List<int> targetArray = new List<int>();

            var charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i].Equals(c))
                {
                    targetArray.Add(i);
                }
            }

            var res = new int[charArray.Length];
            int targetArrayIndex = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (targetArrayIndex < targetArray.Count() && i.Equals(targetArray[targetArrayIndex]))
                {
                    res[i] = 0;
                    targetArrayIndex++;
                }
                else
                {
                    if (i < targetArray[0])
                    {
                        res[i] = Math.Abs(i - targetArray[targetArrayIndex]);
                    }
                    else if (i > targetArray[targetArray.Count() - 1])
                    {
                        res[i] = Math.Abs(i - targetArray[targetArrayIndex - 1]);
                    }
                    else
                    {
                        res[i] = Math.Min(Math.Abs(i - targetArray[targetArrayIndex]), Math.Abs(targetArray[targetArrayIndex - 1] - i));
                    }
                }
            }
            return res;
        }
    }
}
