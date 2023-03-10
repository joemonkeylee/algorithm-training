using TreeNode = DailyCheck.FormTools.Models.TreeNode;

namespace Questions
{
    internal class _100
    {

        public class Solution
        {
            public bool IsSameTree(TreeNode p, TreeNode q)
            {
                if (p == null || q == null) return p == q;
                if (p.val != q.val) return false;
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
        }
    }
}
