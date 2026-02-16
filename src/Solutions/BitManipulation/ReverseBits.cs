namespace Leetcode.src.Solutions.BitManipulation;

// https://leetcode.com/problems/reverse-bits
public class ReverseBitsSolution
{
    public int ReverseBits(int n)
    {
        int res = 0;
        for (int i = 0; i < 32; i++)
        {
            res <<= 1;
            res += (n & 1);
            n >>= 1;
        }
        return res;
    }
}
