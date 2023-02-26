using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 字符串相加
    {
        /// <summary>
        /// 注意边界条件 和最后进位的处理
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string AddStrings(string num1, string num2)
        {
            
            List<int> result = new List<int>(); ;
            int loop = Math.Max(num1.Length, num2.Length);
            int 进位 = 0;
            for (int i = 0; i < loop; i++)
            {
                int a = num1.Length - 1 - i >= 0 ? num1[num1.Length - 1 - i] - '0' : 0;
                int b = num2.Length - 1 - i >= 0 ? num2[num2.Length - 1 - i] - '0' : 0;
                int temp = a + b + 进位;
                if (temp >= 10)
                {
                    进位 = 1;
                    result.Add(temp - 10);
                }
                else
                {
                    进位 = 0;
                    result.Add(temp);
                }
            }

            if (进位 == 1)
            {
                result.Add(1);
            }
            return string.Join("", result.Select(x => x.ToString()).Reverse());
        }
    }
}
