using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    /// <summary>
    /// 给定一个包含大写字母和小写字母的字符串，找到通过这些字母构造成的最长的回文串。
    /// 在构造过程中，请注意区分大小写。比如 "Aa" 不能当做一个回文字符串。假设字符串的长度不会超过 1010。
    /// </summary>
    public class 最长回文串
    {
        public int LongestPalindrome(string s)
        {
            int[] count = new int[128];
            int length = s.Length;
            for (int i = 0; i < length; ++i)
            {
                char c = s[i];
                count[c]++;
            }

            int ans = 0;
            for (int i = 0; i < count.Length; i++)
            {
                ans += count[i] / 2 * 2;
                if (count[i] % 2 == 1 && ans % 2 == 0)
                {
                    ans++;
                }
            }
            return ans;
        }
    }
    ///// <summary>
    ///// 我的思路dict a int 最后算最长偶数/2 (基数-1)/2
    ///// </summary>
    ///// <param name="s"></param>
    ///// <returns></returns>
    //public int LongestPalindrome(string s)
    //{
    //    //int[] arr = new int[52];//A65-Z90 a97-z122 没办法用数组了 见上面解法 用128数组
    //    Dictionary<char, int> dict = new Dictionary<char, int>();
    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        if (dict.ContainsKey(s[i]))
    //        {
    //            dict[s[i]]++;
    //        }
    //        else
    //        {
    //            dict.Add(s[i], 1);
    //        }
    //    }

    //    int length = 0;
    //    int add = 0;
    //    var arr = dict.Values.ToList();
    //    for (int i = 0; i < dict.Keys.Count(); i++)
    //    {
    //        if (arr[i] >= 2)
    //        {
    //            length += (arr[i] / 2) * 2;
    //        }
    //        if (arr[i] % 2 == 1 && add == 0)
    //        {
    //            add = 1;
    //        }
    //    }
    //    return length + add;
    //}
}
