using System.Text;

namespace Leetcode.src.Solutions.Recursion;

// https://leetcode.com/problems/decode-string
public class DecodeStringSolution
{
    int index = 0;
    public string DecodeString(string s)
    {
        StringBuilder result = new StringBuilder();
        int n = s.Length;

        while (index < n && s[index] != ']')
        {
            if (char.IsLetter(s[index]))
            {
                result.Append(s[index++]);
            }
            else
            {
                int k = 0;
                while (index < n && char.IsDigit(s[index]))
                {
                    k = k * 10 + (s[index++] - '0');
                }

                index++;
                string decodedPart = DecodeString(s);
                index++;

                for (int i = 0; i < k; i++)
                {
                    result.Append(decodedPart);
                }
            }
        }

        return result.ToString();
    }
}
