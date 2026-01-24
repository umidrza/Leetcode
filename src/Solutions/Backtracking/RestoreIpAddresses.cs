namespace Leetcode.src.Solutions.Backtracking;

// https://leetcode.com/problems/restore-ip-addresses
public class RestoreIpAddressesSolution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        var res = new List<string>();
        Backtrack(0, new List<int>(), s, res);
        return res;
    }

    void Backtrack(int index, List<int> curr, string s, List<string> res)
    {
        if (index == s.Length && curr.Count == 4)
            res.Add(string.Join(".", curr));

        if (index == s.Length || curr.Count == 4)
            return;

        int num = 0;
        for (int i = index; i < s.Length; i++)
        {
            num = num * 10 + (s[i] - '0');
            if (num > 255) break;

            curr.Add(num);
            Backtrack(i + 1, curr, s, res);
            curr.RemoveAt(curr.Count - 1);

            if (num == 0) break;
        }
    }
}
