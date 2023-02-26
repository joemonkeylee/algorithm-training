using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions.字符串
{
    public class 亦我
    {
        public char[] Replace(char[] a, char[] b, char[] c)
        {
            bool isEqual;
            int beginIndex = Contains(a, b);
            if (beginIndex != -1)
            {
                for (int i = beginIndex; i < a.Length - beginIndex; i++)
                {
                    isEqual = true;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (i + j > a.Length - 1 || a[i + j] != b[j])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    if (isEqual)
                    {
                        a = GetNewArray(a, b, c, i);
                        i += (b.Length - c.Length);
                    }
                }
                return Replace(a, b, c);
            }
            else
            {
                return a;
            }
        }

        private static int Contains(char[] a, char[] b)
        {
            int beginIndex = -1;
            bool isEqual;
            for (int i = 0; i < a.Length; i++)
            {
                isEqual = true;
                for (int j = 0; j < b.Length; j++)
                {
                    if (i + j > a.Length - 1 || a[i + j] != b[j])
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (isEqual)
                {
                    beginIndex = i;
                    break;
                }
            }
            return beginIndex;
        }

        private static char[] GetNewArray(char[] a, char[] b, char[] c, int i)
        {
            char[] array = new char[a.Length + c.Length - b.Length];
            for (int k = 0; k < i; k++)
            {
                array[k] = a[k];
            }
            for (int k = 0; k < c.Length; k++)
            {
                array[k + i] = c[k];
            }
            for (int k = 0; k + i + c.Length < a.Length - 1; k++)
            {
                array[k + i + c.Length] = a[k + i + b.Length];
            }
            a = array;
            return a;
        }

        //public char[] Replace(char[] a, char[] b, char[] c)
        //{
        //    int start = -1;
        //    bool equal;
        //    //模拟查找操作 成功了记录第一个匹配的start
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        equal = true;
        //        for (int j = 0; j < b.Length; j++)
        //        {
        //            if (i + j > a.Length - 1 || a[i + j] != b[j]) { equal = false; break; }
        //        }
        //        if (equal) { start = i; break; }
        //    }
        //    //如果包涵 递归处理source 不包含返回source
        //    if (start != -1)
        //    {
        //        for (int i = start; i < a.Length - start; i++)
        //        {
        //            equal = true;
        //            for (int j = 0; j < b.Length; j++)
        //            {
        //                if (i + j > a.Length - 1 || a[i + j] != b[j]) { equal = false; break; }
        //            }
        //            //题目中没禁止substring 如果禁止每次递归中应该创建临时存储模拟substring
        //            if (equal)
        //            {
        //                //a = a.Substring(0, i) + c + a.Substring(i + b.Length, a.Length - (i + b.Length) - 1);
        //                char[] array = new char[i + c.Length + a.Length - (i + b.Length) - 1];
        //                for (int k = 0; k < i; k++)
        //                {
        //                    array[k] = a[k];
        //                }
        //                for (int k = i; k < c.Length; k++)
        //                {
        //                    array[k] = a[k];
        //                }
        //                for (int k = i + b.Length; k < a.Length - (i + b.Length) - 1; k++)
        //                {
        //                    array[k] = a[k];
        //                }
        //                a = array;
        //                i += (b.Length - c.Length);
        //            }
        //        }
        //        return Replace(a, b, c);
        //    }
        //    else
        //    {
        //        return a;
        //    }
        //}

        //public string Replace(string a, string b, string c)
        //{
        //    int start = -1;
        //    bool equal;
        //    //模拟查找操作 成功了记录第一个匹配的start
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        equal = true;
        //        for (int j = 0; j < b.Length; j++)
        //        {
        //            if (i + j > a.Length - 1 || a[i + j] != b[j]) { equal = false; break; }
        //        }
        //        if (equal) { start = i; break; }
        //    }
        //    //如果包涵 递归处理source 不包含返回source
        //    if (start != -1)
        //    {
        //        for (int i = start; i < a.Length - start; i++)
        //        {
        //            equal = true;
        //            for (int j = 0; j < b.Length; j++)
        //            {
        //                if (i + j > a.Length - 1 || a[i + j] != b[j]) { equal = false; break; }
        //            }
        //            //题目中没禁止substring 如果禁止每次递归中应该创建临时存储模拟substring
        //            if (equal) { a = a.Substring(0, i) + c + a.Substring(i + b.Length, a.Length - (i + b.Length) - 1); i += (b.Length - c.Length); }
        //        }
        //        return Replace(a, b, c);
        //    }
        //    else
        //    {
        //        return a;
        //    }
        //}

        public int IndexOf(String s, String m)
        {
            if (s == null || m == null || m.Length < 1 || m.Length > s.Length)
                return -1;

            char[] ss = s.ToCharArray();
            char[] ms = s.ToCharArray();

            int si = 0;
            int mi = 0;
            int[] next = getNextArray(ms);

            while (si < ss.Length && mi < ms.Length)
            {
                if (ss[si] == ms[mi])
                {
                    si++;
                    mi++;
                }
                else if (next[mi] == -1)
                {
                    si++;
                }
                else
                {
                    mi = next[mi];
                }
            }
            return mi == ms.Length ? si - mi : -1;
        }

        public static int[] getNextArray(char[] ms)
        {
            if (ms.Length == 1)
            {
                return new int[] { -1 };
            }
            int[] next = new int[ms.Length];
            next[0] = -1;
            next[1] = 0;
            int pos = 2;
            int cn = 0;

            while (pos < ms.Length)
            {
                if (ms[pos - 1] == ms[cn])
                {
                    next[pos++] = ++cn;
                }
                else if (cn > 0)
                {
                    cn = next[cn];
                }
                else
                {
                    next[pos++] = 0;
                }
            }
            return next;

        }

        public Dictionary<Node, List<Node>> dict = new Dictionary<Node, List<Node>>();//key 子节点，value 父节点集合

        public Node root;

        public string Check(Node target)
        {
            if (target.left != null)
            {
                if (!dict.Keys.Contains(target.left))
                {
                    if (dict[target.left] == null)
                    {
                        dict[target.left] = new List<Node>();
                    }

                    dict[target.left].AddRange(dict[target]);
                }

                //if (target.left == root || target.right == root)
                //{
                //    return "circle";
                //}

                if (dict[target.left].Contains(target.left) || dict[target.left].Contains(target.right))
                {
                    return "circle";
                }

                if (dict.Keys.Contains(target.left))
                {
                    return "non-tree";
                }

                dict[target.left].Add(target);

                Check(target.left);
            }

            if (target.right != null)
            {
                if (!dict.Keys.Contains(target.right))
                {
                    if (dict[target.right] == null)
                    {
                        dict[target.right] = new List<Node>();
                    }
                    dict[target.right].AddRange(dict[target]);
                }

                //if (target.left == root || target.right == root)
                //{
                //    return "circle";
                //}

                if (dict[target.right].Contains(target.left) || dict[target.right].Contains(target.right))
                {
                    return "circle";
                }

                if (dict.Keys.Contains(target.right))
                {
                    return "non-tree";
                }

                dict[target.right].Add(target);

                Check(target.right);
            }
            return "tree";
        }
    }
}

public class Node
{
    public string value { get; set; }
    public Node left { get; set; }
    public Node right { get; set; }
}

