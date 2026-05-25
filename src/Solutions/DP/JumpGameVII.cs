namespace Leetcode.src.Solutions.DP;

// https://leetcode.com/problems/jump-game-vii/
public class JumpGameVII
{
    public bool CanReach(string s, int minJump, int maxJump)
    {
        int n = s.Length;
        if (s[n - 1] != '0') return false;

        bool[] dp = new bool[n];
        dp[0] = true;
        int reachable = 0;

        for (int i = 1; i < n; i++)
        {
            if (i >= minJump && dp[i - minJump]) reachable++;

            if (i > maxJump && dp[i - maxJump - 1]) reachable--;

            if (reachable > 0 && s[i] == '0')
                dp[i] = true;
        }

        return dp[n - 1];
    }
}
