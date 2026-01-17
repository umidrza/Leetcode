namespace Leetcode.src.Solutions.Hash;

// https://leetcode.com/problems/first-missing-positive
public class FirstMissingPositiveSolution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        // Step 1: Move all non-positive integers to the end of the array
        int nonPosIdx = 0;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] <= 0)
            {
                int temp = nums[i];
                nums[i] = nums[nonPosIdx];
                nums[nonPosIdx] = temp;
                nonPosIdx++;
            }
        }

        // Step 2: Mark the presence of positive integers by negating the corresponding index
        for (int i = nonPosIdx; i < n; i++)
        {
            int num = Math.Abs(nums[i]);
            if (num <= n - nonPosIdx && nums[num - 1 + nonPosIdx] > 0)
            {
                nums[num - 1 + nonPosIdx] *= -1;
            }
        }

        // Step 3: Find the first missing positive integer
        for (int i = nonPosIdx; i < n; i++)
        {
            if (nums[i] > 0)
            {
                return i - nonPosIdx + 1;
            }
        }

        return n - nonPosIdx + 1;
    }
}
