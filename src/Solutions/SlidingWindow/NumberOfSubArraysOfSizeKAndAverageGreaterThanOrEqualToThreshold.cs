namespace Leetcode.src.Solutions.SlidingWindow;

// https://leetcode.com/problems/number-of-sub-arrays-of-size-k-and-average-greater-than-or-equal-to-threshold
public class NumberOfSubArraysOfSizeKAndAverageGreaterThanOrEqualToThreshold
{
    public int NumOfSubarrays(int[] arr, int k, int threshold)
    {
        int n = arr.Length;
        int res = 0, sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += arr[i];
        }
        if (sum / k >= threshold) res++;

        for (int i = k; i < n; i++)
        {
            sum += arr[i];
            sum -= arr[i - k];
            if (sum / k >= threshold) res++;
        }
        
        return res;
    }
}
