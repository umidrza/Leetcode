using System.Text;

namespace Leetcode.src.Solutions.String;

// https://leetcode.com/problems/license-key-formatting
public class LicenseKeyFormattingSolution
{
    public string LicenseKeyFormatting(string s, int k)
    {
        s = s.Replace("-", "");
        var sb = new StringBuilder();
        
        int groupSize = s.Length % k;
        if (groupSize == 0) groupSize = k;

        foreach (char c in s)
        {
            if (groupSize == 0)
            {
                sb.Append('-');
                groupSize = k;
            }

            sb.Append(char.ToUpper(c));
            groupSize--;
        }

        return sb.ToString();
    }
}
