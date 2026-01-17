namespace Leetcode.src.Solutions.PrefixSum;

// https://leetcode.com/problems/ways-to-make-a-fair-array
public class WaysToMakeAFairArray
{
    public int WaysToMakeFair(int[] nums)
    {
        int n = nums.Length;
        int rightEven = 0, rightOdd = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) 
                rightEven += nums[i];
            else 
                rightOdd += nums[i];
        }

        int leftEven = 0, leftOdd = 0;
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0) 
                rightEven -= nums[i];
            else 
                rightOdd -= nums[i];

            int newEven = leftEven + rightOdd;
            int newOdd = leftOdd + rightEven;

            if (newEven == newOdd) 
                result++;

            if (i % 2 == 0) 
                leftEven += nums[i];
            else 
                leftOdd += nums[i];
        }

        return result;
    }
}
