using System.Collections.Generic;
using System.Linq;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 罗马数字转整数
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            dict.Add('I', 1);
            dict.Add('V', 5);
            dict.Add('X', 10);
            dict.Add('L', 50);
            dict.Add('C', 100);
            dict.Add('D', 500);
            dict.Add('M', 1000);

            var arr = s.ToArray();
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i + 1 < arr.Length) && dict[arr[i]] < dict[arr[i + 1]])
                {
                    result -= dict[arr[i]];
                }
                else
                {
                    result += dict[arr[i]];
                }
            }
            return result;
        }
    }
}
