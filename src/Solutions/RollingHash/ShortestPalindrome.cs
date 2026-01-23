using System.Text;

namespace Leetcode.src.Solutions.RollingHash;

// https://leetcode.com/problems/shortest-palindrome
public class ShortestPalindromeSolution
{
    public string ShortestPalindrome(string s)
    {
        string reversed = Reverse(s);
        int[] lps = BuildLps(s + '#' + reversed);
        return reversed.Substring(0, s.Length - lps[^1]) + s;
    }

    int[] BuildLps(string pattern)
    {
        int[] lps = new int[pattern.Length];
        int prevLps = 0;
        int i = 1;

        while (i < pattern.Length)
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

    string Reverse(string s)
    {
        var sb = new StringBuilder();

        for (int i = s.Length - 1; i >= 0; i--)
        {
            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}
