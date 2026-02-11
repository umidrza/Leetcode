namespace Leetcode.src.Solutions.ShortestPath;

// https://leetcode.com/problems/network-delay-time
public class NetworkDelayTimeSolution
{
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        var graph = new List<(int, int)>[n + 1];

        for (int i = 0; i <= n; i++)
        {
            graph[i] = new List<(int, int)>();
        }

        foreach (int[] t in times)
        {
            graph[t[0]].Add((t[1], t[2]));
        }

        var distances = new int[n + 1];
        System.Array.Fill(distances, int.MaxValue);
        distances[k] = 0;

        var pq = new PriorityQueue<int, int>();
        pq.Enqueue(k, 0);

        while (pq.Count > 0)
        {
            int node = pq.Dequeue();

            foreach (var (next, time) in graph[node])
            {
                int newDist = distances[node] + time;

                if (newDist < distances[next])
                {
                    distances[next] = newDist;
                    pq.Enqueue(next, newDist);
                }
            }
        }

        int max = 0;
        for (int i = 1; i <= n; i++)
        {
            if (distances[i] == int.MaxValue) return -1;
            max = Math.Max(max, distances[i]);
        }

        return max;
    }
}
