using System.Collections.Generic;
using System.Text;

namespace DailyCheck.FormTools.Questions.字符串
{

    //示例 1:
    //输入：s = "egg", t = "add" 122 122
    //输出：true

    //示例 2：
    //输入：s = "foo", t = "bar" 122 123
    //输出：false

    //示例 3：
    //输入：s = "paper", t = "title" 12134 12134
    //输出：true
    public class 同构字符串
    {
        //执行用时：
        //76 ms
        //, 在所有 C# 提交中击败了
        //86.49%
        //的用户
        //内存消耗：
        //23.4 MB
        //, 在所有 C# 提交中击败了
        //82.43%
        //的用户
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> map1 = new Dictionary<char, char>();
            Dictionary<char, char> map2 = new Dictionary<char, char>();
            for (int i = 0, j = 0; i < s.Length; i++, j++)
            {
                if (!map1.ContainsKey(s[i]))
                {
                    map1[s[i]] = t[j];
                }

                if (!map2.ContainsKey(t[i]))
                {
                    map2[t[i]] = s[j];
                }

                if (map1[s[i]] != t[j] || map2[t[j]] != s[i])
                {
                    return false;
                }
            }
            return true;
        }

        ////执行用时：
        ////96 ms
        ////, 在所有 C# 提交中击败了
        ////40.54%
        ////的用户
        ////内存消耗：
        ////23.9 MB
        ////, 在所有 C# 提交中击败了
        ////37.84%
        ////的用户
        ///// <summary>
        ///// 将t的字符对应往s中装 获得的新串与t比较
        ///// </summary>
        ///// <param name="s"></param>
        ///// <param name="t"></param>
        ///// <returns></returns>
        //public bool IsIsomorphic(string s, string t)
        //{
        //    Dictionary<char, char> dict1 = new Dictionary<char, char>();
        //    StringBuilder sb1 = new StringBuilder();

        //    Dictionary<char, char> dict2 = new Dictionary<char, char>();
        //    StringBuilder sb2 = new StringBuilder();

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (!dict1.ContainsKey(s[i]))
        //        {
        //            dict1.Add(s[i], t[i]);
        //            sb1.Append(t[i]);
        //        }
        //        else
        //        {
        //            sb1.Append(dict1[s[i]]);
        //        }

        //        if (!dict2.ContainsKey(t[i]))
        //        {
        //            dict2.Add(t[i], s[i]);
        //            sb2.Append(s[i]);
        //        }
        //        else
        //        {
        //            sb2.Append(dict2[t[i]]);
        //        }
        //    }
        //    return (t == sb1.ToString()) && (s == sb2.ToString());
        //}
    }
}
