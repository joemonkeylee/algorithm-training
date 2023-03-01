using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _513
    {
        int val = 0;
        int height = 0;

        public int FindBottomLeftValue(Models.TreeNode root)
        {
            DFS(root, 0);
            return val;
        }

        public void DFS(Models.TreeNode root, int height)
        {
            if (root == null)
            {
                return;
            }
            height++;
            DFS(root.left, height);//先左再右
            DFS(root.right, height);
            if (height > this.height)//如果进来高度比原来高度高 一定是最左边先进来  那么记录最新高度 val赋新值
            {
                this.height = height;
                val = root.val;
            }
        }
    }
}
