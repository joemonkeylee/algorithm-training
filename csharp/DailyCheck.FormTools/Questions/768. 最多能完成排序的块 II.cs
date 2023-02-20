using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCheck.FormTools.Questions
{
    internal class _768
    {
        public int maxChunksToSorted(int[] arr)
        {
            Stack<int> stack = new Stack<int>();
            foreach (int num in arr)
            {
                if (stack.Count > 0 && num < stack.Peek())
                {
                    int head = stack.Pop();
                    while (stack.Count > 0 && num < stack.Peek()) stack.Pop();
                    stack.Push(head);
                }
                else stack.Push(num);
            }
            return stack.Count();
        }
    }
}
