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
                List<int> stack = new List<Integer>();
                for (int num : arr)
                {
                    if (!stack.isEmpty() && num < stack.getLast())
                    {
                        int head = stack.removeLast();
                        while (!stack.isEmpty() && num < stack.getLast()) stack.removeLast();
                        stack.addLast(head);
                    }
                    else stack.addLast(num);
                }
                return stack.size();
            }
        }
}
