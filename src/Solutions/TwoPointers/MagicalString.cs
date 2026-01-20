namespace Leetcode.src.Solutions.TwoPointers;

// https://leetcode.com/problems/magical-string
public class MagicalStringSolution
{
    public int MagicalString(int n)
    {
        if (n <= 3) return 1;

        int res = 1;
        int[] s = new int[n];
        s[0] = 1;
        s[1] = 2;
        s[2] = 2;
        int tail = 3, num = 1;

        for (int i = 2; tail < n; i++)
        {
            for (int j = 0; j < s[i] && tail < n; j++)
            {
                s[tail++] = num;
                if (num == 1) res++;
            }

            num = num == 1 ? 2 : 1;
        }

        return res;
    }
}
