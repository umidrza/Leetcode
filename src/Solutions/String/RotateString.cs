namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/rotate-string
public class RotateStringSolution
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length) return false;
        return (s + s).Contains(goal);
    }
}
