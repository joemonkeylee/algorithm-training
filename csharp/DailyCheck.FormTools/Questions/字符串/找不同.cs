using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 找不同
    {
        public char FindTheDifference(string s, string t)
        {
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
            }

            for (int i = 0; i < t.Length; i++)
            {
                arr[t[i] - 'a']--;
                if (arr[t[i] - 'a'] == -1)
                {
                    return t[i];
                }
            }

            return char.MinValue;
        }
    }
}
