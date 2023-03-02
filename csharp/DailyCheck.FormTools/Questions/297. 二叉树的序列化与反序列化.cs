using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeNode = DailyCheck.FormTools.Models.TreeNode;

namespace DailyCheck.FormTools.Questions
{
    //297. 二叉树的序列化与反序列化 BAD
    internal class _297
    {
        //序列化是将一个数据结构或者对象转换为连续的比特位的操作，进而可以将转换后的数据存储在一个文件或者内存中，同时也可以通过网络传输到另一个计算机环境，采取相反方式重构得到原数据。

        //请设计一个算法来实现二叉树的序列化与反序列化。这里不限定你的序列 / 反序列化算法执行逻辑，你只需要保证一个二叉树可以被序列化为一个字符串并且将这个字符串反序列化为原始的树结构。

        //提示: 输入输出格式与 LeetCode 目前使用的方式一致，详情请参阅 LeetCode 序列化二叉树的格式。你并非必须采取这种方式，你也可以采用其他的方法解决这个问题。

        public string serialize(TreeNode root)
        {
            if (root == null)
            {
                return "#";
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(root.val);
            sb.Append(',');
            sb.Append(serialize(root.left));
            sb.Append(',');
            sb.Append(serialize(root.right));
            return sb.ToString();
        }

        public TreeNode deserialize(string data)
        {
            if ("#".Equals(data))
            {
                return null;
            }
            string[] arr = data.Split(new char[] { ',' });
            TreeNode root = new TreeNode(int.Parse(arr[0]));
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            bool isLeftNull = false;
            int length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                string str = arr[i];
                TreeNode parent = stack.Peek();
                TreeNode node = "#".Equals(str) ? null : new TreeNode(int.Parse(str));
                if (parent.left == null && !isLeftNull)
                {
                    parent.left = node;
                    if (node == null)
                    {
                        isLeftNull = true;
                    }
                }
                else
                {
                    parent.right = node;
                    stack.Pop();
                    isLeftNull = false;
                }
                if (node != null)
                {
                    stack.Push(node);
                }
            }
            return root;
        }

        //public string serialize(TreeNode root)
        //{
        //    return serialize_bfs(root, "");
        //}

        //public string serialize_bfs(TreeNode root, string str)
        //{
        //    if (root == null)
        //    {
        //        str += "None,";
        //    }
        //    else
        //    {
        //        str += root.val.ToString() + ",";
        //        str = serialize_bfs(root.left, str);
        //        str = serialize_bfs(root.right, str);
        //    }
        //    return str;
        //}


        //public TreeNode deserialize(string data = "1,2,3,null,null,4,5")
        //{
        //    string[] dataArray = data.Split(",");
        //    LinkedList<string> dataList = new LinkedList<string>(dataArray.ToList());
        //    var model = deserialize_bfs(dataList);
        //    var str = serialize(model);
        //    return null;
        //}


        //public TreeNode deserialize_bfs(LinkedList<string> dataList)
        //{
        //    if (dataList.First.Value.Equals("null"))
        //    {
        //        dataList.RemoveFirst();
        //        return null;
        //    }

        //    TreeNode root = new TreeNode(int.Parse(dataList.First.Value));
        //    dataList.RemoveFirst();
        //    if (dataList != null)
        //    {
        //        root.left = deserialize_bfs(dataList);
        //        root.right = deserialize_bfs(dataList);
        //    }


        //    return root;
        //}
    }



    //List<TreeNode> list = new List<TreeNode>();
    //// Encodes a tree to a single string.
    //public string serialize(TreeNode root)
    //{
    //    list.Add(root);
    //    bfs(root.left, root.right);
    //    return string.Join("", list);
    //}

    //private void bfs(TreeNode leftNode, TreeNode rightNode)
    //{
    //    list.Add(leftNode);
    //    if (leftNode.right != null)
    //    {
    //        bfs(leftNode.left, leftNode.right);
    //    }

    //    list.Add(rightNode);
    //    bfs(rightNode.left, rightNode.right);

    //    if (leftNode == null && rightNode == null)
    //    {
    //        return;
    //    }
    //}

    //// Decodes your encoded data to tree.
    //public TreeNode deserialize(string data)
    //{
    //    return null;
    //}
}
