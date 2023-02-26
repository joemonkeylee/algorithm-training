using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    /// <summary>
    /// 给定一种规律 pattern 和一个字符串 str ，判断 str 是否遵循相同的规律。
    /// 这里的 遵循 指完全匹配，例如， pattern 里的每个字母和字符串 str 中的每个非空单词之间存在着双向连接的对应规律。
    /// </summary>
    public class 单词规律
    {
        public bool WordPattern(string pattern, string s)
        {
            if (s.Length == 0)
            {
                return false;
            }
            int cnt1 = pattern.Length;
            int cnt2 = s.Split(' ').Length;
            if (cnt1 != cnt2)
            {
                return false;
            }
            string[] str = s.Split(' ');
            char[] c = pattern.ToCharArray();
            Dictionary<char, string> map = new Dictionary<char, string>();
            for (int i = 0; i < cnt1; i++)
            {
                if (map.ContainsKey(c[i]))
                {
                    if (map[c[i]] != str[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (map.Values.Contains(str[i]))
                    {
                        return false;
                    }
                    map.Add(c[i], str[i]);
                }
            }
            return true;
        }

        //输入: pattern = "abba", str = "dog cat cat dog"
        //输出: true

        //输入:pattern = "abba", str = "dog cat cat fish"
        //输出: false

        //输入: pattern = "aaaa", str = "dog cat cat dog"
        //输出: false

        //输入: pattern = "abba", str = "dog dog dog dog"
        //输出: false

        //public bool WordPattern(string pattern, string s)
        //{
        //    var arr = s.Split(' ');
        //    if (pattern.Length != arr.Count())
        //    {
        //        return false;
        //    }
        //    Dictionary<char, string> dict1 = new Dictionary<char, string>();
        //    Dictionary<string, char> dict2 = new Dictionary<string, char>();

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (!dict1.ContainsKey(pattern[i]))
        //        {
        //            dict1.Add(pattern[i], arr[i]);
        //        }

        //        if (!dict2.ContainsKey(arr[i]))
        //        {
        //            dict2.Add(arr[i], pattern[i]);
        //        }

        //        if (dict1[pattern[i]] != arr[i] || dict2[arr[i]] != pattern[i])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
    }
}
