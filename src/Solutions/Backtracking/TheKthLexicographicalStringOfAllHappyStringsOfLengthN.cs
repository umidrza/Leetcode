using System.Text;

namespace Leetcode.src.Solutions.Backtracking;

// https://leetcode.com/problems/the-k-th-lexicographical-string-of-all-happy-strings-of-length-n
public class TheKthLexicographicalStringOfAllHappyStringsOfLengthN
{
    public string GetHappyString(int n, int k)
    {
        char[] chars = new char[] { 'a', 'b', 'c' };
        StringBuilder sb = new StringBuilder();

        bool Backtrack(char prev)
        {
            if (sb.Length == n) return --k == 0;

            foreach (char c in chars)
            {
                if (c == prev) continue;
                sb.Append(c);
                if (Backtrack(c)) return true;
                sb.Remove(sb.Length - 1, 1);
            }
            return false;
        }

        Backtrack(' ');
        return sb.ToString();
    }
}
