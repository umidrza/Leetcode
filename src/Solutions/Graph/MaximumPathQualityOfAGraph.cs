namespace Leetcode.src.Solutions.Graph;

// https://leetcode.com/problems/maximum-path-quality-of-a-graph
public class MaximumPathQualityOfAGraph
{
    public int MaximalPathQuality(int[] values, int[][] edges, int maxTime)
    {
        int n = values.Length;
        var map = new List<(int node, int time)>[n];

        for (int i = 0; i < n; i++)
        {
            map[i] = new List<(int, int)>();
        }

        foreach (int[] edge in edges)
        {
            map[edge[0]].Add((edge[1], edge[2]));
            map[edge[1]].Add((edge[0], edge[2]));
        }

        int res = values[0];
        Backtrack(0, 0, maxTime, 0, ref res, map, values);
        return res;
    }

    void Backtrack(int node, int currTime, int maxTime, int currValue, ref int maxValue, List<(int, int)>[] map, int[] values)
    {
        if (currTime > maxTime) return;
        if (node == 0)
        {
            maxValue = Math.Max(currValue, maxValue);
        }

        foreach (var (next, cost) in map[node])
        {
            int value = values[next];

            values[next] = 0;
            Backtrack(next, currTime + cost, maxTime, currValue + value, ref maxValue, map, values);
            values[next] = value;
        }
    }
}
