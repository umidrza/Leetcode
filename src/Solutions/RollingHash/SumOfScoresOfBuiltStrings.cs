namespace Leetcode.src.Solutions.RollingHash;

// https://leetcode.com/problems/sum-of-scores-of-built-strings
public class SumOfScoresOfBuiltStrings
{
    public long SumScores(string s)
    {
        int[] z = ZFunction(s);

        long score = 0;
        foreach (int i in z)
            score += i;

        return score;
    }

    int[] ZFunction(string s)
    {
        int n = s.Length;
        int l = 0, r = 0;
        int[] z = new int[n];
        z[0] = n;

        for (int i = 1; i < n; i++)
        {
            if (i <= r)
                z[i] = Math.Min(r - i + 1, z[i - l]);

            while (i + z[i] < n && s[z[i]] == s[i + z[i]])
                z[i]++;

            if (i + z[i] - 1 > r)
            {
                l = i;
                r = i + z[i] - 1;
            }
        }

        return z;
    }
}
