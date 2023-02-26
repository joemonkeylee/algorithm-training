using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class Z字形变换
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            string[] arr = new string[numRows];
            int loop = 2 * numRows - 1;
            int middleIndex = numRows - 1;
            int 余数;
            for (int i = 0; i < s.Length; i++)
            {
                余数 = i % (loop - 1);
                if (余数 < middleIndex)//前半段
                {
                    arr[余数] += s[i];
                }
                else if (余数 == middleIndex)//中间
                {
                    arr[middleIndex] += s[i];
                }
                else//后半段
                {
                    arr[loop - 余数 - 1] += s[i];
                }
            }
            return string.Join("", arr);
        }
    }
}
