using System.Text;

namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/repeated-string-match
public class RepeatedStringMatchSolution
{
    public int RepeatedStringMatch(string a, string b)
    {
        var sb = new StringBuilder();
        int count = 0;

        // Repeat until length >= b.Length
        while (sb.Length < b.Length)
        {
            sb.Append(a);
            count++;
        }

        // Check if b is substring
        if (sb.ToString().Contains(b))
            return count;

        // One extra repetition to cover overlap cases
        sb.Append(a);
        count++;

        if (sb.ToString().Contains(b))
            return count;

        return -1;
    }
}
