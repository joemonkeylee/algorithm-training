using DailyCheck.FormTools.BasicUtils;

namespace DailyCheck.FormTools.Questions
{
    // 整数的 数组形式  num 是按照从左到右的顺序表示其数字的数组。

    //例如，对于 num = 1321 ，数组形式是[1, 3, 2, 1] 。
    //给定 num ，整数的 数组形式 ，和整数 k ，返回 整数 num + k 的 数组形式 。

    //示例 1：
    //输入：num = [1,2,0,0], k = 34
    //输出：[1,2,3,4]
    //    解释：1200 + 34 = 1234

    //示例 2：
    //输入：num = [2,7,4], k = 181
    //输出：[4,5,5]
    //    解释：274 + 181 = 455

    //示例 3：
    //输入：num = [2,1,5], k = 806
    //输出：[1,0,2,1]
    //    解释：215 + 806 = 1021

    //提示：
    //1 <= num.length <= 104
    //0 <= num[i] <= 9
    //num 不包含任何前导零，除了零本身
    //1 <= k <= 104

    /// </summary>
    internal class _989
    {
        public int[] num = new int[4];
        public int k = 0;

        public _989(int[] num, int k)
        {
            this.num = num;
            this.k = k;
        }

        //float 单精度浮点数	32	7	±1.5×10E−45 ~ ±3.4×10E38	是基础类型
        //double 双精度浮点数	64	15/16	±5.0×10E−324 ~ ±1.7×10E308	是基础类型
        //decimal 高精度浮点数	128	28	±1.0×10E−28 ~ ±7.9×10E28	否  1e+49 System.OverflowException:“Value was either too large or too small for a Decimal.”

        ///// <summary>
        ///// 不要企图使用将数组转化为数字求和方式 decimal范围也没那么大
        ///// </summary>
        ///// <param name="num"></param>
        ///// <param name="k"></param>
        ///// <returns></returns>
        //public IList<int> Main(int[] num, int k)
        //{
        //    //num数组转数字
        //    //int number = 0;

        //    double number = 0;//这里要定double

        //    int currentIndex = num.Length;
        //    while (currentIndex > 0)
        //    {
        //        if (num.Length - currentIndex < num.Length)
        //        {
        //            number += num[num.Length - currentIndex] * (double)Math.Pow(10, currentIndex - 1);
        //        }
        //        currentIndex--;
        //    }

        //    //求和
        //    decimal sum = Convert.ToDecimal(number + Convert.ToDouble(k));

        //    //整形转整形数组
        //    //int length = 1;
        //    decimal temp = sum;
        //    //while (temp / 10 > 0)
        //    //{
        //    //    length++;
        //    //    temp = temp / 10;
        //    //}
        //    string total = sum.ToString();
        //    int length = total.Length;

        //    int[] result = new int[length];

        //    currentIndex = 0;
        //    temp = sum;
        //    while (currentIndex < length)
        //    {
        //        result[length - currentIndex - 1] = Convert.ToInt32(temp % 10);
        //        temp = (temp - temp % 10) / 10;
        //        currentIndex++;
        //    }
        //    return result;
        //}

        public List<int> Main(int[] num, int k)
        {
            List<int> res = new List<int>();
            for (int i = num.Count() - 1; i >= 0 || k > 0; --i, k /= 10)
            {
                if (i >= 0)
                {
                    k += num[i];
                }
                res.Add(k % 10);
            }
            res.Reverse();
            return res;
        }

        public IList<int> Main0(int[] num, int k)
        {
            int kCopy;

            //1.获取k位数 
            int kLength = 1;
            kCopy = k;
            while (kCopy / 10 > 0)
            {
                kLength++;
                kCopy = kCopy / 10;
            }

            //2.将k转成数组
            int[] num2 = new int[kLength];
            int currentIndex = 0;
            kCopy = k;
            while (currentIndex < kLength)
            {
                num2[kLength - currentIndex - 1] = kCopy % 10;
                kCopy = (kCopy - kCopy % 10) / 10;
                currentIndex++;
            }

            //3.开辟一个数组 长度是两数组长度较大值+1 右对齐求和
            int maxLength = Math.Max(num.Length, num2.Length);
            //int minLength = Math.Min(num.Length, num2.Length);
            int[] res = new int[maxLength + 1];
            int carry = 0;
            int a;
            int b;
            for (int index = 0; index < maxLength; index++)
            {
                if (num.Length - index > 0)
                {
                    a = num[num.Length - index - 1];
                }
                else
                {
                    a = 0;
                }

                if (num2.Length - index > 0)
                {
                    b = num2[num2.Length - index - 1];
                }
                else
                {
                    b = 0;
                }

                if (a + b + carry >= 10)
                {
                    res[maxLength - index] = a + b + carry - 10;
                    carry = 1;
                }
                else
                {
                    res[maxLength - index] = a + b + carry;
                    carry = 0;
                }
            }

            if (carry == 1)
            {
                res[0] = carry;
            }

            //4.如果最高位是0 数组长度-1右移
            int[] result = new int[maxLength];
            if (res[0] == 0)
            {
                for (int i = 0; i < result.Count(); i++)
                {
                    result[i] = res[i + 1];
                }
                return result;
            }
            else
            {
                return res;
            }
        }

        /// <summary>
        /// 默认签名使用工具类
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<int> AddToArrayForm(int[] num, int k)
        {
            int number1 = Tools.GetNumberFromIntArray(num);
            int sum = number1 + k;
            int[] result = Tools.GetIntArray(sum);
            return result;
        }
    }
}
