namespace Leetcode.src.Solutions.Array;

// https://leetcode.com/problems/divide-an-array-into-subarrays-with-minimum-cost-i
public class DivideAnArrayIntoSubarraysWithMinimumCostI
{
    public int MinimumCost(int[] nums)
    {
        int firstMin = int.MaxValue, secondMin = int.MaxValue;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < firstMin)
            {
                secondMin = firstMin;
                firstMin = nums[i];
            }
            else if (nums[i] < secondMin)
            {
                secondMin = nums[i];
            }
        }
        return nums[0] + firstMin + secondMin;
    }
}
