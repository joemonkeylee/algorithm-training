using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 有效的括号
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();
            dict.Add('(', ')');
            dict.Add('{', '}');
            dict.Add('[', ']');
            dict.Add('?', '?');
            Stack<char> stack = new Stack<char>();
            stack.Push('?');

            var arr = s.ToCharArray();
            for (int i = 0; i < arr.Count(); i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    stack.Push(arr[i]);
                }
                else
                {
                    if (arr[i] != dict[stack.Pop()])
                    {
                        return false;
                    }
                }
            }
            return stack.Count() == 1;
        }

        //执行用时：
        //80 ms
        //, 在所有 C# 提交中击败了
        //77.24%
        //的用户
        //内存消耗：
        //22.1 MB
        //, 在所有 C# 提交中击败了
        //49.31%
        //的用户
        ///// <summary>
        ///// 给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串 s ，判断字符串是否有效。
        ///// </summary>
        ///// <param name="s"></param>
        ///// <returns></returns>
        //public bool IsValid(string s)
        //{
        //    Stack<char> stack = new Stack<char>();
        //    var arr = s.ToArray();
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        switch (arr[i])
        //        {
        //            case '(':
        //            case '{':
        //            case '[':
        //                stack.Push(arr[i]);
        //                break;
        //            case ')':
        //                if (stack.Count == 0)
        //                {
        //                    return false;
        //                }
        //                if (stack.Count > 0 && stack.Pop() != '(')
        //                {
        //                    return false;
        //                }
        //                break;
        //            case '}':
        //                if (stack.Count == 0)
        //                {
        //                    return false;
        //                }
        //                if (stack.Count > 0 && stack.Pop() != '{')
        //                {
        //                    return false;
        //                }
        //                break;
        //            case ']':
        //                if (stack.Count == 0)
        //                {
        //                    return false;
        //                }
        //                if (stack.Count > 0 && stack.Pop() != '[')
        //                {
        //                    return false;
        //                }
        //                break;
        //        }
        //    }
        //    return stack.Count() == 0;
        //}
    }
}
