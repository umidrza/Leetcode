namespace Leetcode.MonotonicStack;

//https://leetcode.com/problems/daily-temperatures
public class DailyTemperaturesSolution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        int n = temperatures.Length;
        int[] res = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                int idx = stack.Pop();
                res[idx] = i - idx;
            }
            stack.Push(i);
        }

        return res;
    }
}
