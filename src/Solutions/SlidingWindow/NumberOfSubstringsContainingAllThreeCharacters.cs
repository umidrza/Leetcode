namespace Leetcode.src.Solutions.SlidingWindow;

// https://leetcode.com/problems/number-of-substrings-containing-all-three-characters
public class NumberOfSubstringsContainingAllThreeCharacters
{
    public int NumberOfSubstrings(string s)
    {
        int n = s.Length;
        int[] freq = new int[3];
        int l = 0, res = 0;

        for (int r = 0; r < n; r++)
        {
            freq[s[r] - 'a']++;

            while (freq[0] > 0 && freq[1] > 0 && freq[2] > 0)
            {
                res += n - r;
                freq[s[l] - 'a']--;
                l++;
            }
        }

        return res;
    }
}
