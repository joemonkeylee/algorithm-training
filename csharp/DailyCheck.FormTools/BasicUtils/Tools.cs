using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.BasicUtils
{
    public static class Tools
    {
        /// <summary>
        /// 整数数组转整数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int GetNumberFromIntArray(int[] num)
        {
            int result = 0;
            int currentIndex = num.Length;
            while (currentIndex > 0)
            {
                if (num.Length - currentIndex < num.Length)
                {
                    result += num[num.Length - currentIndex] * Convert.ToInt32(Math.Pow(10, currentIndex - 1));
                }
                currentIndex--;
            }
            return result;
        }

        /// <summary>
        /// 获取整数长度
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int GetLength(int k)
        {
            int length = 1;
            while (k / 10 > 0)
            {
                length++;
                k = k / 10;
            }
            return length;
        }

        /// <summary>
        /// 整数转数组
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] GetIntArray(int k)
        {
            int length = GetLength(k);
            int[] result = new int[length];
            int currentIndex = 0;

            while (k / 10 > 0)
            {
                result[length - currentIndex - 1] = k % 10;
                k = k / 10;
                currentIndex++;
            }
            result[0] = k;
            return result;
        }
    }
}
