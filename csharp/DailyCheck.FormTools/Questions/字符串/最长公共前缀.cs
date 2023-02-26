using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 最长公共前缀
    {
        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder sb = new StringBuilder();

            int min = strs.Select(x => x.Length).Min();

            for (int i = 0; i < min; i++)
            {
                bool ok = true;
                char temp = Char.MinValue;
                for (int j = 0; j < strs.Count(); j++)
                {
                    if (temp == Char.MinValue)
                    {
                        temp = strs[j][i];
                    }
                    else
                    {
                        if (temp != strs[j][i])
                        {
                            ok = false;
                            break;
                        }
                    }
                }

                if (ok)
                {
                    sb.Append(temp);
                }
                else
                {
                    break;
                }
            }
            return sb.ToString();
        }
    }
}
