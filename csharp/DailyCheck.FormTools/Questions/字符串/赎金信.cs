using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 赎金信
    {
        /// <summary>
        /// 能用数组别用字典
        /// </summary>
        /// <param name="ransomNote"></param>
        /// <param name="magazine"></param>
        /// <returns></returns>
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] hash = new int[26];
            for (int i = 0; i < magazine.Length; i++)
            {
                hash[magazine[i] - 'a'] += 1;
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                hash[ransomNote[i] - 'a'] -= 1;
                if (hash[ransomNote[i] - 'a'] < 0) return false;
            }
            return true;
        }
    }
}
