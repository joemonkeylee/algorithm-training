using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 实现strStr
    {
        /// <summary>
        /// KMP 参考 https://leetcode-cn.com/problems/implement-strstr/solution/c-kmp-xi-wang-wo-jiang-ming-bai-liao-kmpsuan-fa-by/
        /// </summary>
        /// <param name="haystack"></param>
        /// <param name="needle"></param>
        /// <returns></returns>
        public int StrStr(string haystack, string needle)
        {

            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length || string.IsNullOrEmpty(haystack))
            {
                return -1;
            }

            return KMP(haystack, needle);
        }

        private int KMP(string haystack, string needle)
        {
            int[] next = GetNext(needle);
            int i = 0;
            int j = 0;
            while (i < haystack.Length)
            {
                if (haystack[i] == needle[j])
                {
                    j++;
                    i++;
                }
                if (j == needle.Length)
                {
                    return i - j;
                }
                else if (i < haystack.Length && haystack[i] != needle[j])
                {
                    if (j != 0)
                        j = next[j - 1];
                    else
                        i++;
                }

            }
            return -1;
        }

        private int[] GetNext(string str)
        {
            int[] next = new int[str.Length];
            next[0] = 0;
            int i = 1;
            int j = 0;
            while (i < str.Length)
            {
                if (str[i] == str[j])
                {
                    j++;
                    next[i] = j;
                    i++;
                }
                else
                {
                    if (j == 0)
                    {
                        next[i] = 0;
                        i++;
                    }
                    else
                    {
                        j = next[j - 1];
                    }
                }
            }
            return next;
        }

        //public int StrStr(string haystack, string needle)
        //{
        //    int n = haystack.Length, m = needle.Length;
        //    char[] s = haystack.ToCharArray(), p = needle.ToCharArray();
        //    // 枚举原串的「发起点」
        //    for (int i = 0; i <= n - m; i++)
        //    {
        //        // 从原串的「发起点」和匹配串的「首位」开始，尝试匹配
        //        int a = i, b = 0;
        //        while (b < m && s[a] == p[b])
        //        {
        //            a++;
        //            b++;
        //        }
        //        // 如果能够完全匹配，返回原串的「发起点」下标
        //        if (b == m) return i;
        //    }
        //    return -1;
        //}

        ///// <summary>
        ///// 差 要用kmp 不会 难受
        ///// </summary>
        ///// <param name="haystack"></param>
        ///// <param name="needle"></param>
        ///// <returns></returns>
        //public int StrStr(string haystack, string needle)
        //{
        //    if (string.IsNullOrEmpty(needle))
        //    {
        //        return 0;
        //    }
        //    if (needle.Length > haystack.Length)
        //    {
        //        return -1;
        //    }
        //    bool ok;
        //    for (int i = 0; i < haystack.Length; i++)
        //    {
        //        ok = true;
        //        for (int j = 0; j < needle.Length; j++)
        //        {
        //            if (i + j >= haystack.Length)//越界没有
        //            {
        //                ok = false;
        //                break;
        //            }
        //            else if (haystack[i + j] != needle[j])//不同也没有
        //            {
        //                ok = false;
        //                break;
        //            }
        //        }
        //        if (ok)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
    }
}
