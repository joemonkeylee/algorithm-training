using System;
using System.Collections.Generic;
using System.Linq;

namespace DailyCheck.FormTools.Questions.字符串
{
    /// <summary>
    /// 0003
    /// </summary>
    public class 无重复字符的最长子串
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }
            else
            {
                int max = 0;
                Dictionary<char, int> dict = new Dictionary<char, int>();
                int start = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.Keys.Contains(s[i]))
                    {
                        start = Math.Max(start, dict[s[i]] + 1);
                    }

                    dict[s[i]] = i;
                    max = Math.Max(max, i - start + 1);
                }
                return max;
            }
        }
    }
}
