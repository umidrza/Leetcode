namespace Leetcode.src.Solutions.BinarySearch;

// https://leetcode.com/problems/peak-index-in-a-mountain-array
public class PeakIndexInAMountainArray
{
    public int PeakIndexInMountainArray(int[] arr)
    {
        int min = 0, max = arr.Length - 1;

        while (min < max)
        {
            int mid = (min + max) / 2;

            if (arr[mid] < arr[mid + 1])
                min = mid + 1;
            else
                max = mid;
        }

        return min;
    }
}
