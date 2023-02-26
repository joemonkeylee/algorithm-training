using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    /// <summary>
    /// 编写一个函数，其作用是将输入的字符串反转过来。输入字符串以字符数组 char[] 的形式给出。
    /// 不要给另外的数组分配额外的空间，你必须原地修改输入数组、使用 O(1) 的额外空间解决这一问题。
    /// 你可以假设数组中的所有字符都是 ASCII 码表中的可打印字符。
    /// </summary>
    public class 反转字符串
    {

        //输入：["h","e","l","l","o"]
        //输出：["o","l","l","e","h"]

        //输入：["H","a","n","n","a","h"]
        //输出：["h","a","n","n","a","H"]

        public void ReverseString(char[] s)
        {
            int loop = 0;
            if (s.Length % 2 == 1)//基数中位数不用处理
            {
                loop = (s.Length - 1) / 2;
            }
            else
            {
                loop = s.Length / 2;
            }

            char temp;
            for (int i = 0; i < loop; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - i - 1];
                s[s.Length - i - 1] = temp;
            }
        }
    }
}
