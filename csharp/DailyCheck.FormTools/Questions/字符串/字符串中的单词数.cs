using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 字符串中的单词数
    {
        /// <summary>
        /// 100%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int CountSegments(string s)
        {
            //return s.Split(' ').Where(x => !string.IsNullOrEmpty(x)).Count();
            int count = 0;
            bool isBlank = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    isBlank = true;
                }
                else
                {
                    if (s[i] != ' ' && isBlank)
                    {
                        count++;
                        isBlank = false;
                    }
                }
            }
            return count;
        }
    }
}
