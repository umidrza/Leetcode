namespace Leetcode.src.Solutions.BitManipulation;

// https://leetcode.com/problems/binary-number-with-alternating-bits
public class BinaryNumberWithAlternatingBits
{
    public bool HasAlternatingBits(int n)
    {
        int x = n ^ (n >> 1);
        return (x & (x + 1)) == 0;
    }
}
