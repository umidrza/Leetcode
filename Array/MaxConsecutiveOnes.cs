namespace Leetcode.Array;

public class MaxConsecutiveOnes
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int curr = 0;
        int max = 0;

        foreach (int num in nums)
        {
            if (num == 1)
            {
                curr++;
                max = Math.Max(curr, max);
            }
            else
            {
                curr = 0;
            }
        }

        return max;
    }
}
