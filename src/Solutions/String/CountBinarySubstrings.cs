namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/count-binary-substrings
public class CountBinarySubstringsSolution
{
    public int CountBinarySubstrings(string s)
    {
        int curr = 1, prev = 0, result = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] != s[i - 1])
            {
                result += Math.Min(curr, prev);
                prev = curr;
                curr = 1;
            }
            else
            {
                curr++;
            }
        }

        result += Math.Min(curr, prev);
        return result;
    }
}
