### 思路

循环存长度 过去用dict 现在用了list 变慢了

### 代码

```c#

    public int LengthOfLongestSubstring(string s) {
        if (s.Length <= 1)
        {
            return s.Length;
        }
        var arr = s.ToCharArray();
        int res = 0;
        List<char> temp = new List<char>();
        int current = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (!temp.Contains(arr[i]))
            {
                temp.Add(arr[i]);
            }
            else
            {
                res = Math.Max(temp.Count, res);
                temp.Clear();
                i = current;
                current++;
            }
        }
        return Math.Max(temp.Count, res);
    }

```

**复杂度分析**
- 时间复杂度：O(n)
- 空间复杂度：O(n)