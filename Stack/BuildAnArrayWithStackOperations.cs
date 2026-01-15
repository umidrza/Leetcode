namespace Leetcode.Stack;

//https://leetcode.com/problems/build-an-array-with-stack-operations
public class BuildAnArrayWithStackOperations
{
    public IList<string> BuildArray(int[] target, int n)
    {
        IList<string> res = new List<string>();
        int index = 0;

        for (int i = 1; i <= n; i++)
        {
            if (index >= target.Length) break;

            if (i == target[index])
            {
                res.Add("Push");
                index++;
            }
            else
            {
                res.Add("Push");
                res.Add("Pop");
            }
        }

        return res;
    }
}
