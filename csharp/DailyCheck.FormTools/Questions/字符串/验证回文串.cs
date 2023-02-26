using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 验证回文串
    {
        /// <summary>
        /// 严格验证 包括空格和符号
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindromeStrict(string s)
        {
            int left, right;
            if (s.Length % 2 == 0)
            {
                left = s.Length / 2;
                right = left + 1;
            }
            else
            {
                left = (s.Length - 1) / 2 - 1;
                right = (s.Length - 1) / 2 + 1;
            }

            while (left >= 0 && right <= s.Length - 1)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
            }
            return true;
        }


        /// <summary>
        /// 给定一个字符串，验证它是否是回文串，只考虑字母和数字字符，可以忽略字母的大小写。
        /// //a man, a plan, a canal: panama
        ///amanaplanacanalpanama
        /// 非严格验证 不包括空格和符号
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int left = 0;
            int right = s.Length - 1;

            while (left <= right)
            {
                while (left < right && !isChar(s[left]))
                {
                    left++;
                }
                while (left < right && !isChar(s[right]))
                {
                    right--;
                }

                if (s[left] != s[right])
                {
                    return false;
                }

                left++;
                right--;
            }
            return true;
        }

        public bool isChar(char ch)
        {
            if ((ch >= '0' && ch <= '9') || (ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                return true;
            }
            return false;
        }
    }
}


