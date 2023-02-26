using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 判断子序列
    {
        /// <summary>
        /// 我不懂啥是贪心 好像看了看讲解 用了一种最好的方式？
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0)
            {
                return true;
            }

            if (s.Length > t.Length)
            {
                return false;
            }

            int left = 0;
            int index = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (s[index] == t[i])
                {
                    index++;
                    if (index == s.Length)
                    {
                        return true;
                    }
                }
                else
                {
                    if (index > 0)
                    {
                        if (s[0] == t[i])
                        {
                            left = i;
                        }
                    }
                    if (left != 0)
                    {
                        i = left;
                        left = 0;
                    }
                }
            }
            return false;
        }
    }
}
