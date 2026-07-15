namespace Leetcode.src.Solutions.Math_Problems;

// https://leetcode.com/problems/gcd-of-odd-and-even-sums
public class GcdOfOddAndEvenSums
{
    public int GcdOfOddEvenSums(int n)
    {
        return n;

        // Brut-Force
        int sumOdd = 0;
        int sumEven = 0;

        int num = 1;
        for (int i = 0; i < n; i++)
        {
            sumOdd += num++;
            sumEven += num++;
        }

        return GCD(sumOdd, sumEven);

    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        return Math.Abs(a);
    }
}
