using System.Text;

namespace Leetcode.src.Solutions.BitManipulation;

//
public class AddBinarySolution
{
    public string AddBinary(string a, string b)
    {
        StringBuilder res = new StringBuilder();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int bit1 = i >= 0 ? a[i] - '0' : 0;
            int bit2 = j >= 0 ? b[j] - '0' : 0;

            int sum = bit1 + bit2 + carry;
            res.Insert(0, sum % 2);
            carry = sum / 2;

            i--;
            j--;
        }

        return res.ToString();
    }
}
