﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _3
    {
        //        给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串 的长度。

        //示例 1:
        //输入: s = "abcabcbb"
        //输出: 3 
        //解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。

        //示例 2:
        //输入: s = "bbbbb"
        //输出: 1
        //解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。

        //示例 3:
        //输入: s = "pwwkew"
        //输出: 3
        //解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
        //     请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。

        //提示：
        //0 <= s.length <= 5 * 104
        //s 由英文字母、数字、符号和空格组成

        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 1)
            {
                return s.Length;
            }
            var arr = s.ToCharArray();
            int res = 0;
            List<char> temp = new List<char>();
            int current = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!temp.Contains(arr[i]))
                {
                    temp.Add(arr[i]);
                }
                else
                {
                    res = Math.Max(temp.Count, res);
                    temp.Clear();
                    i = current;
                    current++;
                }
            }
            return res;
        }
    }
}
