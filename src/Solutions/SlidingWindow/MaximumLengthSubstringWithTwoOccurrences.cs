namespace Leetcode.src.Solutions.SlidingWindow;

// https://leetcode.com/problems/maximum-length-substring-with-two-occurrences
public class MaximumLengthSubstringWithTwoOccurrences
{
    public int MaximumLengthSubstring(string s)
    {
        int[] freq = new int[26];
        int res = 0;

        int l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            int c = s[r] - 'a';
            freq[c]++;

            while (l < r && freq[c] > 2)
            {
                freq[s[l] - 'a']--;
                l++;
            }

            res = Math.Max(r - l + 1, res);
        }

        return res;
    }
}
