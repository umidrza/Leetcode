namespace Leetcode.src.Solutions.BitManipulation;

// https://leetcode.com/problems/binary-gap
public class BinaryGapSolution
{
    public int BinaryGap(int n)
    {
        int max = 0;
        int position = 0;
        int last = -1;

        while (n > 0)
        {

            if ((n & 1) == 1)
            {
                if (last != -1)
                    max = Math.Max(max, position - last);

                last = position;
            }

            n >>= 1;
            position++;
        }

        return max;
    }
}
