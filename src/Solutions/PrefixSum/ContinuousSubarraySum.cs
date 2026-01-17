namespace Leetcode.src.Solutions.PrefixSum;

// https://leetcode.com/problems/continuous-subarray-sum
public class ContinuousSubarraySum
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();
        map[0] = -1;
        int prefixSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum = (prefixSum + nums[i]) % k;

            if (!map.TryAdd(prefixSum, i) && i - map[prefixSum] >= 2)
                return true;
        }

        return false;
    }
}
