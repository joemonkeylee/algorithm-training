using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 检测大写字母
    {
        public bool DetectCapitalUse(string word)
        {
            int n = word.Length;
            int count = 0;
            for (int i = 0; i < n; ++i)
            {
                if (word[i] < 'a')//计算有多少大写字母
                {
                    count++;
                }
            }
            if (count == n || count == 1 && (word[0] < 'a') || count == 0)
            {
                return true;
            }
            return false;
        }



        ///// <summary>
        ///// 65-90 大写
        ///// </summary>
        ///// <param name="word"></param>
        ///// <returns></returns>
        //public bool DetectCapitalUse(string word)
        //{
        //    if (word[0] >= 65 && word[0] <= 90)
        //    {
        //        int flag;
        //        for (int i = 1; i < word.Length; i++)
        //        {
        //            if (word[1] >= 65 && word[1] <= 90)
        //            {
        //                flag = 1;
        //            }
        //            else
        //            {
        //                flag = 2;
        //            }

        //            if ((word[i] >= 65 && word[i] <= 90 && flag == 2) || ((word[i] < 65 || word[i] > 90) && flag == 1))
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        for (int i = 1; i < word.Length; i++)
        //        {
        //            if (word[i] >= 65 && word[i] <= 90)
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}
    }
}
