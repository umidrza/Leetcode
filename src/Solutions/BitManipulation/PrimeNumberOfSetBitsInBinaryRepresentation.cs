using System.Numerics;

namespace Leetcode.src.Solutions.BitManipulation;

// https://leetcode.com/problems/prime-number-of-set-bits-in-binary-representation
public class PrimeNumberOfSetBitsInBinaryRepresentation
{
    public int CountPrimeSetBits(int left, int right)
    {
        HashSet<int> primes = new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 19 };
        int result = 0;

        for (int i = left; i <= right; i++)
        {
            int bitCount = BitOperations.PopCount((uint)i);
            if (primes.Contains(bitCount))
                result++;
        }

        return result;
    }
}
