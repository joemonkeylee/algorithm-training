using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 字符串中的第一个唯一字符
    {
        //s = "leetcode"
        //返回 0

        //s = "loveleetcode"
        //返回 2
        public int FirstUniqChar(string s)
        {
            int[] arr = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                if (arr[s[i] - 'a'] == 0)
                {
                    arr[s[i] - 'a'] = i + 1;
                }
                else if (arr[s[i] - 'a'] != 0)
                {
                    arr[s[i] - 'a'] = -1;
                }
                else
                {
                    continue;
                }
            }
            var list = arr.Where(x => x > 0).ToList();

            if (list.Count() == 0)
            {
                return -1;
            }
            else
            {
                return list.Min() - 1;
            }
        }
    }
}
