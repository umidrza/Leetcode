namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/repeated-substring-pattern
public class RepeatedSubstringPatternSolution
{
    public bool RepeatedSubstringPattern(string s)
    {
        string doubled = s + s;
        string trimmed = doubled.Substring(1, doubled.Length - 2);
        return trimmed.Contains(s);
    }
}
