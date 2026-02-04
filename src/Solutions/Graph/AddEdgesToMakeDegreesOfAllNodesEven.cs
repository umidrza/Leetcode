namespace Leetcode.src.Solutions.Graph;

// https://leetcode.com/problems/add-edges-to-make-degrees-of-all-nodes-even
public class AddEdgesToMakeDegreesOfAllNodesEven
{
    public bool IsPossible(int n, IList<IList<int>> edges)
    {
        int[] degree = new int[n + 1];
        var graph = new HashSet<long>();

        foreach (var e in edges)
        {
            int u = e[0], v = e[1];
            degree[u]++;
            degree[v]++;
            graph.Add(Encode(u, v));
        }

        var odd = new List<int>();
        for (int i = 1; i <= n; i++)
        {
            if (degree[i] % 2 == 1)
                odd.Add(i);
        }

        if (odd.Count == 0)
            return true;

        if (odd.Count == 2)
            return FixTwoOdd(odd[0], odd[1], n, graph);

        if (odd.Count == 4)
            return FixFourOdd(odd, graph);

        return false;
    }

    private bool FixTwoOdd(int a, int b, int n, HashSet<long> graph)
    {
        if (!graph.Contains(Encode(a, b)))
            return true;

        for (int x = 1; x <= n; x++)
        {
            if (x == a || x == b) continue;
            if (!graph.Contains(Encode(a, x)) &&
                !graph.Contains(Encode(b, x)))
                return true;
        }
        return false;
    }

    private bool FixFourOdd(List<int> odd, HashSet<long> graph)
    {
        int a = odd[0], b = odd[1], c = odd[2], d = odd[3];

        return
            (!graph.Contains(Encode(a, b)) && !graph.Contains(Encode(c, d))) ||
            (!graph.Contains(Encode(a, c)) && !graph.Contains(Encode(b, d))) ||
            (!graph.Contains(Encode(a, d)) && !graph.Contains(Encode(b, c)));
    }

    private long Encode(int u, int v)
    {
        if (u > v) (u, v) = (v, u);
        return ((long)u << 32) | (uint)v;
    }
}
