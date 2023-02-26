using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 二进制求和
    {
        public string AddBinary(string a, string b)
        {
            int loop = Math.Max(a.Length, b.Length);
            List<string> ans = new List<string>();
            int ca = 0;
            for (int i = 0; i < loop; i++)
            {
                int sum = ca;

                if (a.Length - i - 1 >= 0)
                {
                    sum += Convert.ToInt32(a[a.Length - i - 1].ToString());
                }
                if (b.Length - i - 1 >= 0)
                {
                    sum += Convert.ToInt32(b[b.Length - i - 1].ToString());
                }
                ans.Add((sum % 2).ToString());
                ca = sum / 2;
            }
            ans.Add(ca == 1 ? "1" : "");
            ans.Reverse();
            return string.Join("", ans);
        }

        /// <summary>
        ///  a = "1010", b = "1011"  10101
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        //public string AddBinary(string a, string b)
        //{
        //    if (b.Length > a.Length)
        //    {
        //        a = a.PadLeft(b.Length, '0');
        //    }
        //    else
        //    {
        //        b = b.PadLeft(a.Length, '0');
        //    }

        //    var arr1 = a.ToCharArray();
        //    var arr2 = b.ToCharArray();
        //    var loop = Math.Min(arr1.Length, arr2.Length);
        //    var result = "";
        //    var add = "0";
        //    for (int i = loop - 1; !(i < 0); i--)
        //    {
        //        if (arr1[i] == '0' && arr2[i] == '0' && add == "0")
        //        {
        //            result = "0" + result;
        //            add = "0";
        //        }
        //        else if (arr1[i] == '0' && arr2[i] == '1' && add == "0")
        //        {
        //            result = "1" + result;
        //            add = "0";
        //        }
        //        else if (arr1[i] == '1' && arr2[i] == '0' && add == "0")
        //        {
        //            result = "1" + result;
        //            add = "0";
        //        }
        //        else if (arr1[i] == '1' && arr2[i] == '1' && add == "0")
        //        {
        //            result = "0" + result;
        //            add = "1";
        //        }
        //        else if (arr1[i] == '0' && arr2[i] == '0' && add == "1")
        //        {
        //            result = "1" + result;
        //            add = "0";
        //        }
        //        else if (arr1[i] == '0' && arr2[i] == '1' && add == "1")
        //        {
        //            result = "0" + result;
        //            add = "1";
        //        }
        //        else if (arr1[i] == '1' && arr2[i] == '0' && add == "1")
        //        {
        //            result = "0" + result;
        //            add = "1";
        //        }
        //        else if (arr1[i] == '1' && arr2[i] == '1' && add == "1")
        //        {
        //            result = "1" + result;
        //            add = "1";
        //        }
        //    }

        //    if (add == "1")
        //    {
        //        result = "1" + result;
        //    }
        //    return result;
        //}
    }
}
