namespace Leetcode.src.Solutions.MonotonicStack;

//https://leetcode.com/problems/largest-rectangle-in-histogram
public class LargestRectangleInHistogram
{
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        int maxArea = 0;
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i <= n; i++)
        {
            int currHeight = (i == n) ? 0 : heights[i];

            while (stack.Count > 0 && currHeight < heights[stack.Peek()])
            {
                int lastHeight = heights[stack.Pop()];

                int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;
                maxArea = Math.Max(maxArea, lastHeight * width);
            }

            stack.Push(i);
        }

        return maxArea;
    }
}