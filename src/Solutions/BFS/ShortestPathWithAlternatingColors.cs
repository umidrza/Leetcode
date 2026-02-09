namespace Leetcode.src.Solutions.BFS;

// https://leetcode.com/problems/shortest-path-with-alternating-colors
public class ShortestPathWithAlternatingColors
{
    public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
    {
        List<int>[] redGraph = new List<int>[n];
        List<int>[] blueGraph = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            redGraph[i] = new List<int>();
            blueGraph[i] = new List<int>();
        }

        foreach (var e in redEdges)
            redGraph[e[0]].Add(e[1]);

        foreach (var e in blueEdges)
            blueGraph[e[0]].Add(e[1]);

        int[] res = new int[n];
        Array.Fill(res, -1);

        var seen = new HashSet<(int node, bool color)>();
        var q = new Queue<(int node, bool color)>();

        q.Enqueue((0, true));
        q.Enqueue((0, false));
        seen.Add((0, true));
        seen.Add((0, false));

        int length = 0;

        while (q.Count > 0)
        {
            int count = q.Count;

            for (int i = 0; i < count; i++)
            {
                var (node, color) = q.Dequeue();

                if (res[node] == -1)
                    res[node] = length;

                var graph = color ? blueGraph : redGraph;
                foreach (int next in graph[node])
                {
                    if (seen.Contains((next, !color))) continue;
                    seen.Add((next, !color));
                    q.Enqueue((next, !color));
                }
            }
            length++;
        }

        return res;
    }
}
