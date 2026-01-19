namespace Leetcode.src.Solutions.BinarySearch;

// https://leetcode.com/problems/binary-search
public class BinarySearch
{
    public int Search(int[] nums, int target)
    {
        int min = 0, max = nums.Length - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;

            if (nums[mid] > target)
                max = mid - 1;
            else if (nums[mid] < target)
                min = mid + 1;
            else
                return mid;
        }

        return -1;
    }
}
