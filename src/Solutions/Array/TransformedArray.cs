namespace Leetcode.src.Solutions.Array;

// https://leetcode.com/problems/transformed-array
public class TransformedArray
{
    public int[] ConstructTransformedArray(int[] nums)
    {
        int n = nums.Length;
        int[] res = new int[n];

        for (int i = 0; i < n; i++)
        {
            res[i] = nums[((i + nums[i]) % n + n) % n];
        }

        return res;
    }
}
