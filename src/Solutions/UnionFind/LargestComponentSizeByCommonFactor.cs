namespace Leetcode.src.Solutions.UnionFind;

// https://leetcode.com/problems/largest-component-size-by-common-factor
public class LargestComponentSizeByCommonFactor
{
    public int LargestComponentSize(int[] nums)
    {
        var dsu = new DSU();

        foreach (int num in nums)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    dsu.Union(i, num);
                    dsu.Union(num, num / i);
                }
            }
        }

        int res = 0;
        var freq = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            int parent = dsu.Find(num);

            if (!freq.ContainsKey(parent))
                freq[parent] = 0;
            freq[parent]++;
            res = Math.Max(res, freq[parent]);
        }

        return res;
    }
}

class DSU
{
    private Dictionary<int, int> parent;

    public DSU()
    {
        parent = new Dictionary<int, int>();
    }

    public int Find(int x)
    {
        if (parent.ContainsKey(x) && parent[x] != x)
            return parent[x] = Find(parent[x]);
        return parent[x] = x;
    }

    public void Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);
        parent[rootY] = rootX;
    }
}