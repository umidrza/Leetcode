namespace Leetcode.src.Solutions.DivideAndConquer;

// https://leetcode.com/problems/reverse-pairs

public class ReversePairsSolution
{
    public int ReversePairs(int[] nums)
    {
        int n = nums.Length;
        return MergeSortAndCount(nums, new int[n], 0, n - 1);
    }

    private int MergeSortAndCount(int[] nums, int[] temp, int start, int end)
    {
        if (start >= end) return 0;

        int mid = (start + end) / 2;
        int count = MergeSortAndCount(nums, temp, start, mid) + MergeSortAndCount(nums, temp, mid + 1, end);

        int j = mid + 1;
        for (int i = start; i <= mid; i++)
        {
            while (j <= end && nums[i] > nums[j] * 2L)
                j++;
            count += j - (mid + 1);
        }

        Merge(nums, temp, start, mid, end);
        return count;
        
    }

    private void Merge(int[] nums, int[] temp, int start, int mid, int end)
    {
        int i = start;
        int j = mid + 1;
        int k = start;

        while (i <= mid && j <= end)
        {
            if (nums[i] <= nums[j])
                temp[k++] = nums[i++];
            else
                temp[k++] = nums[j++];
        }

        while (i <= mid)
            temp[k++] = nums[i++];

        while (j <= end)
            temp[k++] = nums[j++];

        for (int idx = start; idx <= end; idx++)
            nums[idx] = temp[idx];
    }
}