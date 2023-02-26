using System.Collections.Generic;
using System.Linq;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 有效的字母异位词
    {
        /// <summary>
        /// 看了别人真一行代码后 这种好差 仅测试
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        //public bool IsAnagram(string s, string t)
        //{
        //    return string.Join("", s.ToCharArray().OrderBy(x => x)) == string.Join("", t.ToCharArray().OrderBy(x => x));
        //}

        /// <summary>
        /// 常规思路 自己想的 基本一次过 注意最后一句
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            else
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for (int i = 0; i < s.Length; i++)
                {
                    if (dict.ContainsKey(s[i]))
                    {
                        dict[s[i]]++;
                    }
                    else
                    {
                        dict.Add(s[i], 1);
                    }
                    if (dict.ContainsKey(t[i]))
                    {
                        dict[t[i]]--;
                    }
                    else
                    {
                        dict.Add(t[i], -1);
                    }
                }
                return !dict.Select(x => x.Value).Any(x => x != 0);
            }
        }
    }
}
