using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 最长回文子串
    {
        //public string LongestPalindrome(string s)
        //{
        //    string result = "";
        //    int max = 0;
        //    string temp;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = i; j < s.Length; j++)
        //        {
        //            temp = s.Substring(i, j - i + 1);
        //            if (IsPalindrome(temp) && temp.Length > max)
        //            {
        //                max = temp.Length;
        //                result = temp;
        //            }
        //        }
        //    }
        //    return result;
        //}

        //public bool IsPalindrome(string s)
        //{
        //    int left, right;
        //    if (s.Length < 2)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        if (s.Length % 2 == 0)
        //        {
        //            left = 0 + (s.Length / 2) - 1; //1234 0123
        //            right = left + 1;
        //        }
        //        else
        //        {
        //            left = right = (s.Length - 1) / 2; //12345 01234
        //        }

        //        while (left >= 0 && right <= s.Length - 1 && left <= right)
        //        {
        //            if (s[left] != s[right])
        //            {
        //                return false;
        //            }
        //            left--;
        //            right++;
        //        }
        //        return true;
        //    }
        //}/

        //public string LongestPalindrome(string s)
        //{
        //    string result = "";
        //    int max = 0;
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        for (int j = i; j < s.Length; j++)
        //        {
        //            if (IsPalindrome(s, i, j) && (j - i + 1 > max))
        //            {
        //                max = j - i + 1;
        //                result = s.Substring(i, j - i + 1);
        //            }
        //        }
        //    }
        //    return result;
        //}

        ////两端到中间
        //public bool IsPalindrome(string s, int left, int right)
        //{
        //    while (left <= right)
        //    {
        //        if (s[left] != s[right])
        //        {
        //            return false;
        //        }
        //        left++;
        //        right--;
        //    }
        //    return true;
        //}


        string ans = "";
        public string LongestPalindrome(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                helper(i, i, s);// 回文子串长度是奇数,最中间是同一个数,所以取一个就行
                helper(i, i + 1, s);// 回文子串长度是偶数,取两个数字
            }
            return ans;
        }
        public void helper(int m, int n, string s)
        {
            while (m >= 0 && n < s.Length && s[m] == s[n])
            {
                m--;
                n++;
            }
            // 注意此处m,n的值循环完后  是恰好不满足循环条件的时刻
            // mn两个边界不能取 所以应该取m+1到n-1的区间  长度是n-m-1
            if (n - m - 1 > ans.Length)
            {
                //substring要取[m+1,n-1]这个区间 
                //end处的值不取,所以下面写的是n不是n-1
                ans = s.Substring(m + 1, n - m - 1);
            }
        }
    }
}
