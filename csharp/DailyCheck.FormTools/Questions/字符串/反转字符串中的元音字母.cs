using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    /// <summary>
    /// 编写一个函数，以字符串作为输入，反转该字符串中的元音字母。
    /// </summary>
    public class 反转字符串中的元音字母
    {
        //输入："hello"
        //输出："holle"

        //输入："leetcode"
        //输出："leotcede"
        public string ReverseVowels(string s)
        {
            if (s.Length <= 1)
            {
                return s;
            }
            List<char> list = new List<char>();
            list.Add('a');
            list.Add('e');
            list.Add('i');
            list.Add('o');
            list.Add('u');
            list.Add('A');
            list.Add('E');
            list.Add('I');
            list.Add('O');
            list.Add('U');

            var arr = s.ToCharArray();
            int left = 0;
            int right = arr.Length - 1;
            char temp;
            while (true)
            {
                while (left < arr.Length && !list.Contains(arr[left]))
                {
                    left++;
                }

                while (right > 0 && !list.Contains(arr[right]))
                {
                    right--;
                }

                if (left < right)
                {
                    temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
                else
                {
                    break;
                }
            }
            return string.Join("", arr);
        }
    }
}
