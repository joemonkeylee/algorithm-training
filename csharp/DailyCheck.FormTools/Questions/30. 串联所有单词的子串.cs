namespace DailyCheck.FormTools.Questions
{
    internal class _30
    {
        //给定一个字符串 s 和一个字符串数组 words。 words 中所有字符串 长度相同。
        // s 中的 串联子串 是指一个包含 words 中所有字符串以任意顺序排列连接起来的子串。
        //例如，如果 words = ["ab", "cd", "ef"]， 那么 "abcdef"， "abefcd"，"cdabef"， "cdefab"，"efabcd"， 和 "efcdab" 都是串联子串。 "acdbef" 不是串联子串，因为他不是任何 words 排列的连接。
        //返回所有串联字串在 s 中的开始索引。你可以以 任意顺序 返回答案。

        //示例 1：
        //输入：s = "barfoothefoobarman", words = ["foo","bar"]
        //输出：[0,9]
        //解释：因为 words.length == 2 同时 words[i].length == 3，连接的子字符串的长度必须为 6。
        //子串 "barfoo" 开始位置是 0。它是 words 中以["bar", "foo"] 顺序排列的连接。
        //子串 "foobar" 开始位置是 9。它是 words 中以["foo", "bar"] 顺序排列的连接。
        //输出顺序无关紧要。返回[9, 0] 也是可以的。

        //示例 2：
        //输入：s = "wordgoodgoodgoodbestword", words = ["word", "good", "best", "word"]
        //输出：[]
        //解释：因为 words.length == 4 并且 words[i].length == 4，所以串联子串的长度必须为 16。
        //s 中没有子串长度为 16 并且等于 words 的任何顺序排列的连接。
        //所以我们返回一个空数组。

        //示例 3：
        //输入：s = "barfoofoobarthefoobarman", words = ["bar", "foo", "the"]
        //输出：[6,9,12]
        //解释：因为 words.length == 3 并且 words[i].length == 3，所以串联子串的长度必须为 9。
        //子串 "foobarthe" 开始位置是 6。它是 words 中以["foo", "bar", "the"] 顺序排列的连接。
        //子串 "barthefoo" 开始位置是 9。它是 words 中以["bar", "the", "foo"] 顺序排列的连接。
        //子串 "thefoobar" 开始位置是 12。它是 words 中以["the", "foo", "bar"] 顺序排列的连接。

        //提示：
        //1 <= s.length <= 104
        //1 <= words.length <= 5000
        //1 <= words[i].length <= 30
        //words[i] 和 s 由小写英文字母组成


        //没做出来
        public IList<int> FindSubstring(string s, string[] words)
        {
            IList<int> res = new List<int>();
            int m = words.Length, n = words[0].Length, ls = s.Length;
            for (int i = 0; i < n; i++)
            {
                if (i + m * n > ls)
                {
                    break;
                }
                Dictionary<string, int> differ = new Dictionary<string, int>();
                for (int j = 0; j < m; j++)
                {
                    string word = s.Substring(i + j * n, n);
                    if (!differ.ContainsKey(word))
                    {
                        differ.Add(word, 0);
                    }
                    differ[word]++;
                }
                foreach (string word in words)
                {
                    if (!differ.ContainsKey(word))
                    {
                        differ.Add(word, 0);
                    }
                    differ[word]--;
                    if (differ[word] == 0)
                    {
                        differ.Remove(word);
                    }
                }
                for (int start = i; start < ls - m * n + 1; start += n)
                {
                    if (start != i)
                    {
                        string word = s.Substring(start + (m - 1) * n, n);
                        if (!differ.ContainsKey(word))
                        {
                            differ.Add(word, 0);
                        }
                        differ[word]++;
                        if (differ[word] == 0)
                        {
                            differ.Remove(word);
                        }
                        word = s.Substring(start - n, n);
                        if (!differ.ContainsKey(word))
                        {
                            differ.Add(word, 0);
                        }
                        differ[word]--;
                        if (differ[word] == 0)
                        {
                            differ.Remove(word);
                        }
                    }
                    if (differ.Count == 0)
                    {
                        res.Add(start);
                    }
                }
            }
            return res;
        }


        public List<List<string>> permute(string[] nums)
        {
            int len = nums.Length;
            // 使用一个动态数组保存所有可能的全排列
            List<List<string>> res = new List<List<string>>();
            if (len == 0)
            {
                return res;
            }

            bool[] used = new bool[len];
            List<string> path = new List<string>();

            dfs(nums, len, 0, path, used, res);
            return res;
        }

        private void dfs(string[] nums, int len, int depth,
                         List<string> path, bool[] used,
                         List<List<string>> res)
        {
            if (depth == len)
            {
                res.Add(path);
                return;
            }

            // 在非叶子结点处，产生不同的分支，这一操作的语义是：在还未选择的数中依次选择一个元素作为下一个位置的元素，这显然得通过一个循环实现。
            for (int i = 0; i < len; i++)
            {
                if (!used[i])
                {
                    path.Add(nums[i]);
                    used[i] = true;

                    dfs(nums, len, depth + 1, path, used, res);
                    // 注意：下面这两行代码发生 「回溯」，回溯发生在从 深层结点 回到 浅层结点 的过程，代码在形式上和递归之前是对称的
                    used[i] = false;
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}
