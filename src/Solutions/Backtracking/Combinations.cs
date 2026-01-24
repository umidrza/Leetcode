namespace Leetcode.src.Solutions.Backtracking;

// https://leetcode.com/problems/combinations
public class Combinations
{
    public IList<IList<int>> Combine(int n, int k)
    {
        var res = new List<IList<int>>();
        Backtrack(n, k, 1, new List<int>(), res);
        return res;
    }

    void Backtrack(int n, int k, int num, List<int> curr, IList<IList<int>> res)
    {
        if (curr.Count == k)
        {
            res.Add(new List<int>(curr));
            return;
        }

        for (int i = num; i <= n; i++)
        {
            curr.Add(i);
            Backtrack(n, k, i + 1, curr, res);
            curr.RemoveAt(curr.Count - 1);
        }
    }
}
