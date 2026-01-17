namespace Leetcode.src.Solutions.Array;

//https://leetcode.com/problems/max-consecutive-ones
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
