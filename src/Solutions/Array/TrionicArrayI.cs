namespace Leetcode.src.Solutions.Array;

// https://leetcode.com/problems/trionic-array-i
public class TrionicArrayI
{
    public bool IsTrionic(int[] nums)
    {
        int n = nums.Length, i = 0;
        while (i + 1 < n && nums[i] < nums[i + 1]) i++;
        if (i == 0 || i == n - 1) return false;

        int p = i;
        while (i + 1 < n && nums[i] > nums[i + 1]) i++;
        if (i == p || i == n - 1) return false;

        while (i + 1 < n && nums[i] < nums[i + 1]) i++;
        return i == n - 1;
    }
}
