namespace Leetcode.src.Solutions.DivideAndConquer;

// https://leetcode.com/problems/beautiful-array
public class BeautifulArraySolution
{
    Dictionary<int, int[]> memo = new Dictionary<int, int[]>();
    public int[] BeautifulArray(int n)
    {
        if (n == 1) return [1];
        if (memo.ContainsKey(n))
            return memo[n];

        int[] ans = new int[n];
        int i = 0;

        foreach (int x in BeautifulArray((n + 1) / 2))
            ans[i++] = 2 * x - 1;

        foreach (int x in BeautifulArray(n / 2))
            ans[i++] = 2 * x;

        memo[n] = ans;
        return ans;
    }
}
