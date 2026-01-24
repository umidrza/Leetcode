namespace Leetcode.src.Solutions.Recursion;

// https://leetcode.com/problems/find-kth-bit-in-nth-binary-string
public class FindKthBitInNthBinaryString
{
    public char FindKthBit(int n, int k)
    {
        var memo = new int[n + 1][];
        memo[1] = [0];
        Construct(n, memo);
        return (char)(memo[n][k - 1] + '0');
    }

    int[] Construct(int n, int[][] memo)
    {
        if (memo[n] != null) return memo[n];

        memo[n] = [..Construct(n - 1, memo), 1, ..Reverse(Invert(memo[n - 1]))];
        return memo[n];
    }

    int[] Invert(int[] arr)
    {
        int n = arr.Length;
        int[] res = new int[n];

        for (int i = 0; i < n; i++)
        {
            res[i] = arr[i] == 1 ? 0 : 1;
        }

        return res;
    }

    int[] Reverse(int[] arr)
    {
        int n = arr.Length;
        int[] res = new int[n];

        for (int i = 0; i < n; i++)
        {
            res[i] = arr[n - i - 1];
        }

        return res;
    }
}
