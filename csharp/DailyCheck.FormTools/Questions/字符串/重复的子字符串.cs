using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    /// <summary>
    /// 给定一个非空的字符串，判断它是否可以由它的一个子串重复多次构成。给定的字符串只含有小写英文字母，并且长度不超过10000。
    /// </summary>
    public class 重复的子字符串
    {
        //【没看太懂】

        //如果您的字符串 S 包含一个重复的子字符串，那么这意味着您可以多次 “移位和换行”`您的字符串，并使其与原始字符串匹配。
        //例如：abcabc
        //移位一次：cabcab
        //移位两次：bcabca
        //移位三次：abcabc

        //现在字符串和原字符串匹配了，所以可以得出结论存在重复的子串。
        //基于这个思想，可以每次移动k个字符，直到匹配移动 length - 1 次。但是这样对于重复字符串很长的字符串，效率会非常低。在 LeetCode 中执行时间超时了。
        //为了避免这种无用的环绕，可以创建一个新的字符串 str，它等于原来的字符串 S 再加上 S 自身，这样其实就包含了所有移动的字符串。
        //比如字符串：S = acd，那么 str = S + S = acdacd
        //acd 移动的可能：dac、cda。其实都包含在了 str 中了。就像一个滑动窗口
        //一开始 acd(acd) ，移动一次 ac(dac)d，移动两次 a(cda)cd。循环结束
        //所以可以直接判断 str 中去除首尾元素之后，是否包含自身元素。如果包含。则表明存在重复子串。


        //https://leetcode-cn.com/problems/repeated-substring-pattern/solution/jian-dan-ming-liao-guan-yu-javaliang-xing-dai-ma-s/
        /// <summary>
        /// 论怎么移动 字符串总在字符串X2收尾拼接去头去尾后的串中 就说明他可以
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool RepeatedSubstringPattern(string s)
        {
            string str = s + s;
            return str.Substring(1, str.Length - 2).IndexOf(s) != -1;
        }

        //public bool RepeatedSubstringPattern(string s)
        //{
        //    string temp = "";
        //    for (int i = 1; i <= s.Length / 2; i++)
        //    {
        //        if (s.Length % i == 0)
        //        {
        //            bool b = true;
        //            int share = s.Length / i;
        //            for (int j = 0; j < share; j++)
        //            {
        //                if (j == 0)
        //                {
        //                    temp = s.Substring(i * j, i);
        //                }
        //                else
        //                {
        //                    if (temp != s.Substring(i * j, i))
        //                    {
        //                        b = false;
        //                        continue;
        //                    }
        //                }
        //            }
        //            if (b)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //    }
        //    return false;
        //}
    }
}
