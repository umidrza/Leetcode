namespace Leetcode.src.Solutions.SlidingWindow;

// https://leetcode.com/problems/contains-duplicate-ii
public class ContainsDuplicateII
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        if (k == 0) return false;
        int n = nums.Length;
        var set = new HashSet<int>();

        for (int i = 0; i < Math.Min(k, n); i++)
        {
            if (!set.Add(nums[i])) return true;
        }

        for (int i = k; i < n; i++)
        {
            if (!set.Add(nums[i])) return true;
            set.Remove(nums[i - k]);
        }

        return false;
    }
}
