namespace Leetcode.src.Solutions.RollingHash;

// https://leetcode.com/problems/longest-happy-prefix
public class LongestHappyPrefix
{
    public string LongestPrefix(string s)
    {
        int[] lps = BuildLps(s);
        return s.Substring(0, lps[s.Length - 1]);
    }

    int[] BuildLps(string pattern)
    {
        int n = pattern.Length;
        int[] lps = new int[n];
        int i = 1, prevLps = 0;

        while (i < n)
        {
            if (pattern[i] == pattern[prevLps])
            {
                prevLps++;
                lps[i] = prevLps;
                i++;
            }
            else if (prevLps == 0)
            {
                lps[i] = 0;
                i++;
            }
            else
            {
                prevLps = lps[prevLps - 1];
            }
        }

        return lps;
    }
}
