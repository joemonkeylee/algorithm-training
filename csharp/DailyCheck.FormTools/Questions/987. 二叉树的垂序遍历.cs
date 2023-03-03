using TreeNode = DailyCheck.FormTools.Models.TreeNode;


namespace DailyCheck.FormTools.Questions
{
    internal class _987
    {
        //给你二叉树的根结点 root ，请你设计算法计算二叉树的 垂序遍历 序列。
        //对位于(row, col) 的每个结点而言，其左右子结点分别位于(row + 1, col - 1) 和(row + 1, col + 1) 。树的根结点位于(0, 0) 。
        //二叉树的 垂序遍历 从最左边的列开始直到最右边的列结束，按列索引每一列上的所有结点，形成一个按出现位置从上到下排序的有序列表。如果同行同列上有多个结点，则按结点的值从小到大进行排序。
        //返回二叉树的 垂序遍历 序列。

        public class Solution
        {
            public IList<IList<int>> VerticalTraversal(TreeNode root)
            {
                List<Tuple<int, int, int>> nodes = new List<Tuple<int, int, int>>();
                DFS(root, 0, 0, nodes);
                nodes.Sort((a, b) =>
                {
                    if (a.Item1 != b.Item1)
                    {
                        return a.Item1 - b.Item1;
                    }
                    else if (a.Item2 != b.Item2)
                    {
                        return a.Item2 - b.Item2;
                    }
                    else
                    {
                        return a.Item3 - b.Item3;
                    }
                });
                IList<IList<int>> ans = new List<IList<int>>();
                int size = 0;
                int lastcol = int.MinValue;
                foreach (Tuple<int, int, int> tuple in nodes)
                {
                    int col = tuple.Item1, row = tuple.Item2, value = tuple.Item3;
                    if (col != lastcol)
                    {
                        lastcol = col;
                        ans.Add(new List<int>());
                        size++;
                    }
                    ans[size - 1].Add(value);
                }
                return ans;
            }

            public void DFS(TreeNode node, int row, int col, List<Tuple<int, int, int>> nodes)
            {
                if (node == null)
                {
                    return;
                }
                nodes.Add(new Tuple<int, int, int>(col, row, node.val));
                DFS(node.left, row + 1, col - 1, nodes);
                DFS(node.right, row + 1, col + 1, nodes);
            }
        }
    }
}
