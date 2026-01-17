namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/masking-personal-information
public class MaskingPersonalInformation
{
    public string MaskPII(string s)
    {
        if (s.Contains("@"))
            return MaskEmail(s);
        else
            return MaskPhone(s);
    }

    private string MaskEmail(string s)
    {
        s = s.ToLower();
        int atIndex = s.IndexOf('@');

        char first = s[0];
        char last = s[atIndex - 1];
        string domain = s.Substring(atIndex);

        return $"{first}*****{last}{domain}";
    }

    private string MaskPhone(string s)
    {
        string digits = "";
        foreach (char c in s)
        {
            if (char.IsDigit(c))
                digits += c;
        }

        string local = "***-***-" + digits.Substring(digits.Length - 4);

        int countryLength = digits.Length - 10;
        if (countryLength == 0)
            return local;

        return "+" + new string('*', countryLength) + "-" + local;
    }
}
