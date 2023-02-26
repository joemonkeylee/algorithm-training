using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 最后一个单词的长度
    {
        /// <summary>
        /// 就是从后往前遇到空格就过滤掉继续遍历，记录下end（如果从后往前最先遇到的不是空格，那就说明end就是len-1）
        /// 第二次遇到空格就停止，记录下start
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int LengthOfLastWord(string s)
        {
            int end = s.Length - 1;
            while (end >= 0 && s[end] == ' ')
            {
                end--;
            }
            if (end < 0)
            {
                return 0;
            }
            int start = end;
            while (start >= 0 && s[start] != ' ')
            {
                start--;
            }
            return end - start;
        }
    }
}
