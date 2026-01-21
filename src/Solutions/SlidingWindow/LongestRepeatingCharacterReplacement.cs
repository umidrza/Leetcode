namespace Leetcode.src.Solutions.SlidingWindow;

// https://leetcode.com/problems/longest-repeating-character-replacement
public class LongestRepeatingCharacterReplacement
{
    public int CharacterReplacement(string s, int k)
    {
        int[] freq = new int[26];
        int l = 0, maxFreq = 0, res = 0;

        for (int r = 0; r < s.Length; r++)
        {
            freq[s[r] - 'A']++;
            maxFreq = Math.Max(freq[s[r] - 'A'], maxFreq);

            while ((r - l + 1) - maxFreq > k)
            {
                freq[s[l] - 'A']--;
                l++;
            }

            res = Math.Max(r - l + 1, res);
        }

        return res;
    }
}
