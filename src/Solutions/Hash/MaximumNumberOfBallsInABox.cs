namespace Leetcode.src.Solutions.Hash;

// https://leetcode.com/problems/maximum-number-of-balls-in-a-box
public class MaximumNumberOfBallsInABox
{
    public int CountBalls(int lowLimit, int highLimit)
    {
        Dictionary<int, int> freq = new();
        int res = 0;

        for (int i = lowLimit; i <= highLimit; i++)
        {
            int num = i;
            int box = 0;

            while (num > 0)
            {
                box += num % 10;
                num /= 10;
            }

            if (!freq.ContainsKey(box))
                freq[box] = 0;

            freq[box]++;
            res = Math.Max(res, freq[box]);
        }

        return res;
    }
}
