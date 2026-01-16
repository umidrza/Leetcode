namespace Leetcode.String;

//https://leetcode.com/problems/detect-capital
public class DetectCapital
{
    public bool DetectCapitalUse(string word)
    {
        int upper = 0;
        foreach (var c in word)
            if (IsUpper(c)) upper++;

        bool allUpper = upper == word.Length;
        bool allLower = upper == 0;
        bool firstUpper = upper == 1 && IsUpper(word[0]);

        return allUpper || allLower || firstUpper;
    }

    private bool IsUpper(char c)
    {
        return c >= 'A' && c <= 'Z';
    }
}
