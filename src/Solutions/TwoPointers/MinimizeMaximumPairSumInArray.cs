namespace Leetcode.src.Solutions.TwoPointers;

// https://leetcode.com/problems/minimize-maximum-pair-sum-in-array
public class MinimizeMaximumPairSumInArray
{
    public int MinPairSum(int[] nums)
    {
        int n = nums.Length;
        System.Array.Sort(nums);
        int res = 0;

        for (int i = 0; i < n / 2; i++)
        {
            res = Math.Max(res, nums[i] + nums[n - i - 1]);
        }

        return res;
    }
}
