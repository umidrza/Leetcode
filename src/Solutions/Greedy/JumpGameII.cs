namespace Leetcode.src.Solutions.Greedy;

// https://leetcode.com/problems/jump-game-ii/
public class JumpGameII
{
    Dictionary<int, int> memo = new Dictionary<int, int>();
    public int Jump(int[] nums, int i = 0)
    {
        if (memo.ContainsKey(i)) return memo[i];
        if (i == nums.Length - 1) return 0;

        int minJumps = int.MaxValue;
        for (int j = nums[i]; j > 0; j--)
        {
            if (i + j < nums.Length)
            {
                int jumps = Jump(nums, i + j);
                if (jumps != int.MaxValue)
                {
                    minJumps = Math.Min(minJumps, jumps + 1);
                    memo[i] = minJumps;
                }
            }
        }

        return minJumps;
    }
}
