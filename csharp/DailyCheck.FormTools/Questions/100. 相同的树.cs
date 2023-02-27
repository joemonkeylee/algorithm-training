using TreeNode = DailyCheck.FormTools.Models.TreeNode;

namespace Questions
{
    internal class _100
    {

        public class Solution
        {
            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                var list1 = new List<TreeNode>();
                list1 = GetListFromNodes(p, list1);

                var list2 = new List<TreeNode>();
                list2 = GetListFromNodes(q, list2);

                if (list1.Count != list2.Count())
                {
                    return false;
                }
                else
                {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        if (list1[i].val != list2[i].val)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            private List<TreeNode> GetListFromNodes(TreeNode node, List<TreeNode> result)
            {
                result.Add(node);
                GetListFromNodes(node.left, result);
                GetListFromNodes(node.right, result);
                return result;
            }
        }
    }
}
