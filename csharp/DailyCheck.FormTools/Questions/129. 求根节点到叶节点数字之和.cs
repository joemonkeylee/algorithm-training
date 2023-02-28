

namespace DailyCheck.FormTools.Questions
{
    internal class _129
    {
        public int SumNumbers(Models.TreeNode root)
        {

            return dfs(root, 0);
        }

        public int dfs(Models.TreeNode root, int prevSum)
        {
            if (root == null)
            {
                return 0;
            }
            int sum = prevSum * 10 + root.val;
            if (root.left == null && root.right == null)
            {
                return sum;
            }
            else
            {
                return dfs(root.left, sum) + dfs(root.right, sum);
            }
        }
    }
}
