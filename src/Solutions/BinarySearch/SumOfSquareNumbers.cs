namespace Leetcode.src.Solutions.BinarySearch;

// https://leetcode.com/problems/sum-of-square-numbers
public class SumOfSquareNumbers
{
    public bool JudgeSquareSum(int c)
    {
        long left = 0, right = (long)Math.Sqrt(c);

        while (left <= right)
        {
            long curr = left * left + right * right;
            if (curr > c) right--;
            else if (curr < c) left++;
            else return true;
        }

        return false;
    }
}
