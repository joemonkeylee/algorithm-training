### 思路

bfs 应该不是最优解 c#中的linklist 可以RemoveFirst

### 代码

```c#
  
    public string serialize(TreeNode root)
    {
        return serialize_bfs(root, "");
    }

    public string serialize_bfs(TreeNode root, string str)
    {
        if (root == null)
        {
            str += "None,";
        }
        else
        {
            str += root.val.ToString() + ",";
            str = serialize_bfs(root.left, str);
            str = serialize_bfs(root.right, str);
        }
        return str;
    }

    public TreeNode deserialize(string data)
    {
        string[] dataArray = data.Split(",");
        LinkedList<string> dataList = new LinkedList<string>(dataArray.ToList());
        return deserialize_bfs(dataList);
    }


    public TreeNode deserialize_bfs(LinkedList<string> dataList)
    {
        if (dataList.First.Value.Equals("None"))
        {
            dataList.RemoveFirst();
            return null;
        }

        TreeNode root = new TreeNode(int.Parse(dataList.First.Value));
        dataList.RemoveFirst();
        root.left = deserialize_bfs(dataList);
        root.right = deserialize_bfs(dataList);

        return root;
    }

```

**复杂度分析**
- 时间复杂度：O(n)
- 空间复杂度：O(n)