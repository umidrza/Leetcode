namespace Leetcode.src.Solutions.Sorting;

// https://leetcode.com/problems/sort-an-array
public class SortAnArray
{
    public int[] SortArray(int[] nums)
    {
        QuickSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void QuickSort(int[] nums, int left, int right)
    {
        if (left >= right) return;

        int pivotIndex = Partition(nums, left, right);

        QuickSort(nums, left, pivotIndex - 1);
        QuickSort(nums, pivotIndex + 1, right);
    }

    private int Partition(int[] nums, int left, int right)
    {
        int randomIndex = Random.Shared.Next(left, right + 1);
        Swap(nums, right, randomIndex);
        int pivot = nums[right];
        int i = left;

        for (int j = left; j < right; j++)
        {
            if (nums[j] < pivot)
            {
                Swap(nums, i, j);
                i++;
            }
        }

        Swap(nums, i, right);
        return i;
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

public class SortAnArray2
{
    public int[] SortArray(int[] nums)
    {
        int n = nums.Length;
        MergeSort(nums, new int[n], 0, n - 1);
        return nums;
    }

    private void MergeSort(int[] nums, int[] temp, int left, int right)
    {
        if (left >= right) return;

        int mid = left + (right - left) / 2;

        MergeSort(nums, temp, left, mid);
        MergeSort(nums, temp, mid + 1, right);

        Merge(nums, temp, left, mid, right);
    }

    private void Merge(int[] nums, int[] temp, int left, int mid, int right)
    {
        int i = left;
        int j = mid + 1;
        int k = left;

        while (i <= mid && j <= right)
        {
            if (nums[i] <= nums[j])
                temp[k++] = nums[i++];
            else
                temp[k++] = nums[j++];
        }

        while (i <= mid)
        {
            temp[k++] = nums[i++];
        }

        while (j <= right)
        {
            temp[k++] = nums[j++];
        }

        for (int idx = left; idx <= right; idx++)
        {
            nums[idx] = temp[idx];
        }
    }
}