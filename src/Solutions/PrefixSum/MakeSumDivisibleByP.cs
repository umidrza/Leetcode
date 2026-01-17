namespace Leetcode.src.Solutions.PrefixSum;

// https://leetcode.com/problems/make-sum-divisible-by-p
public class MakeSumDivisibleByP
{
    public int MinSubarray(int[] nums, int p)
    {
        int n = nums.Length;

        long totalSum = 0;
        foreach (int num in nums)
            totalSum += num;

        int target = (int)(totalSum % p);
        if (target == 0) return 0;

        var map = new Dictionary<int, int>();
        map[0] = -1; 

        long prefixSum = 0;
        int result = n;

        for (int i = 0; i < n; i++)
        {
            prefixSum = (prefixSum + nums[i]) % p;
            int currentMod = (int)prefixSum;

            int needed = (currentMod - target + p) % p;
            if (map.ContainsKey(needed))
                result = Math.Min(result, i - map[needed]);

            map[currentMod] = i;
        }

        return result == n ? -1 : result;
    }
}
