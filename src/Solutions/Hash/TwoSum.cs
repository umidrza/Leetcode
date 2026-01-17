namespace Leetcode.src.Solutions.Hash;

// https://leetcode.com/problems/two-sum
public class TwoSumSolution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int key = target - nums[i];
            if (map.ContainsKey(key))
                return [map[key], i];

            map[nums[i]] = i;
        }

        return [];
    }
}
