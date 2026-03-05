namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string
public class MinimumChangesToMakeAlternatingBinaryString
{
    public int MinOperations(string s)
    {
        char[] c = s.ToCharArray();
        int count = 0;

        for (int i = 1; i < s.Length; i++)
        {
            if (c[i] == c[i - 1])
            {
                c[i] = c[i] == '0' ? '1' : '0';
                count++;
            }
        }

        return Math.Min(count, s.Length - count);
    }
}
