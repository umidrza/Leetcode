namespace Leetcode.src.Solutions.BFS;

// https://leetcode.com/problems/minimum-score-of-a-path-between-two-cities
public class MinimumScoreOfAPathBetweenTwoCities
{
    public int MinScore(int n, int[][] roads)
    {
        var graph = new List<(int node, int distance)>[n + 1];

        for (int i = 0; i <= n; i++)
        {
            graph[i] = new List<(int, int)>();
        }

        foreach (int[] road in roads)
        {
            int a = road[0], b = road[1], distance = road[2];
            graph[a].Add((b, distance));
            graph[b].Add((a, distance));
        }

        int res = int.MaxValue;
        bool[] seen = new bool[n + 1];
        Queue<int> q = new Queue<int>();

        q.Enqueue(1);
        seen[1] = true;

        while (q.Count > 0)
        {
            int node = q.Dequeue();

            foreach (var (next, distance) in graph[node])
            {
                res = Math.Min(res, distance);

                if (seen[next]) continue;
                q.Enqueue(next);
                seen[next] = true;
            }
        }

        return res;
    }
}
