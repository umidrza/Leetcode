using Leetcode.src.Definitions;

namespace Leetcode.src.Solutions.MonotonicStack;

// https://leetcode.com/problems/next-greater-node-in-linked-list
public class NextGreaterNodeInLinkedList
{
    public int[] NextLargerNodes(ListNode head)
    {
        List<int> values = new List<int>();
        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }

        int n = values.Count;
        int[] answer = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && values[i] > values[stack.Peek()])
            {
                answer[stack.Pop()] = values[i];
            }
            stack.Push(i);
        }

        return answer;
    }
}
