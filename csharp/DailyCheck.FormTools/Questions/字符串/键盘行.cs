using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    /// <summary>
    /// 给你一个字符串数组 words ，只返回可以使用在 美式键盘 同一行的字母打印出来的单词。键盘如下图所示。
    /// 美式键盘 中：
    /// 第一行由字符 "qwertyuiop" 组成。
    /// 第二行由字符 "asdfghjkl" 组成。
    /// 第三行由字符 "zxcvbnm" 组成。
    /// </summary>
    public class 键盘行
    {

        //输入：words = ["Hello","Alaska","Dad","Peace"]
        //输出：["Alaska","Dad"]

        //输入：words = ["omk"]
        //输出：[]

        //输入：words = ["adsdf","sfd"]
        //输出：["adsdf","sfd"]

        public string[] FindWords(string[] words)
        {
            List<string> result = new List<string>();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in "qwertyuiop".ToCharArray())
            {
                dict.Add(item, 1);
            }
            foreach (var item in "asdfghjkl".ToCharArray())
            {
                dict.Add(item, 2);
            }
            foreach (var item in "zxcvbnm".ToCharArray())
            {
                dict.Add(item, 3);
            }
            int line;
            char[] arr;
            for (int i = 0; i < words.Length; i++)
            {
                arr = words[i].ToLower().ToCharArray();
                line = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (j == 0)
                    {
                        line = dict[arr[j]];
                    }
                    else
                    {
                        if (line != dict[arr[j]])
                        {
                            line = 0;
                            break;
                        }
                    }
                }
                if (line != 0)
                {
                    result.Add(words[i]);
                }
            }
            return result.ToArray();
        }
    }
}
