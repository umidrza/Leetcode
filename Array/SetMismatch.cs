namespace Leetcode.Array;

public class SetMismatch
{
    public int[] FindErrorNums(int[] nums)
    {
        int n = nums.Length;
        bool[] seen = new bool[n + 1];
        int duplicate = -1, missing = -1;

        for (int i = 0; i < n; i++)
        {
            if (seen[nums[i]])
                duplicate = nums[i];
            seen[nums[i]] = true;
        }

        for (int i = 1; i < n + 1; i++)
        {
            if (!seen[i])
            {
                missing = i;
                break;
            }
        }
        return new int[2] { duplicate, missing };
    }
}
