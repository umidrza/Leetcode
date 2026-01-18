namespace Leetcode.src.Solutions.Sorting;

// https://leetcode.com/problems/kth-largest-element-in-an-array

// Quick Select approach
public class KthLargestElementInAnArray
{
    private static readonly Random random = new Random();

    public int FindKthLargest(int[] nums, int k)
    {
        return QuickSelect(nums, 0, nums.Length - 1, k);
    }

    private int QuickSelect(int[] nums, int left, int right, int k)
    {
        if (left == right) return nums[left];

        int pivotIndex = Partition(nums, left, right);

        if (pivotIndex + 1 > k)
            return QuickSelect(nums, left, pivotIndex - 1, k);
        else if (pivotIndex + 1 < k)
            return QuickSelect(nums, pivotIndex + 1, right, k);
        else
            return nums[pivotIndex];
    }

    private int Partition(int[] nums, int left, int right)
    {
        int randomIndex = random.Next(left, right + 1);
        (nums[randomIndex], nums[right]) = (nums[right], nums[randomIndex]);
        int pivot = nums[right];
        int i = left;

        for (int j = left; j < right; j++)
        {
            if (nums[j] > pivot)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
            }
        }

        (nums[i], nums[right]) = (nums[right], nums[i]);
        return i;
    }
}

// Priority Queue approach
public class KthLargestElementInAnArray2
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums)
        {
            minHeap.Enqueue(num, num);

            if (minHeap.Count > k)
                minHeap.Dequeue();
        }

        return minHeap.Dequeue();
    }
}