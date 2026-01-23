namespace Leetcode.src.Solutions.RollingHash;

// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string
public class FindTheIndexOfTheFirstOccurrenceInAString
{
    public int StrStr(string haystack, string needle)
    {
        int[] lps = BuildLps(needle);
        int i = 0, j = 0;

        while (i < haystack.Length)
        {
            if (haystack[i] == needle[j])
            {
                i++;
                j++;
            }
            else if (j == 0)
            {
                i++;
            }
            else
            {
                j = lps[j - 1];
            }

            if (j == needle.Length)
            {
                return needle.Length - j;
            }
        }

        return -1;
    }

    int[] BuildLps(string pattern)
    {
        int n = pattern.Length;
        int[] lps = new int[n];
        int prevLps = 0, i = 1;

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
