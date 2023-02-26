using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class Excel表列序号
    {
        public int TitleToNumber(string columnTitle)
        {
            int result = 0;
            var arr = columnTitle.ToCharArray();
            for (int i = 0; i < arr.Count(); i++)
            {
                result += (int)Math.Pow(26, arr.Length - i - 1) * (arr[i] - 'A' + 1);
            }
            return result;
        }

        //public string ConvertToTitle(int cn)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    while (cn > 0)
        //    {
        //        cn--;
        //        sb.Append((char)(cn % 26 + 'A'));
        //        cn /= 26;
        //    }
        //    return string.Join("", sb.ToString().Reverse());
        //}
    }
}
