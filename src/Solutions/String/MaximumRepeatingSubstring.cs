namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/maximum-repeating-substring
public class MaximumRepeatingSubstring
{
    public int MaxRepeating(string sequence, string word)
    {
        int k = 0;
        string repeated = word;

        while (sequence.Contains(repeated))
        {
            k++;
            repeated += word;
        }

        return k;
    }
}
