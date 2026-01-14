namespace Leetcode.Array;

//https://leetcode.com/problems/plus-one
public class PlusOneSolution
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;

        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
                continue;
            }
            
            digits[i]++;
            return digits;
            
        }

        int[] res = new int[n + 1];
        res[0] = 1;
        return res;
    }
}
