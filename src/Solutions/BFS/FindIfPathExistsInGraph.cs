namespace Leetcode.src.Solutions.BFS;

// https://leetcode.com/problems/find-if-path-exists-in-graph
public class FindIfPathExistsInGraph
{
    public bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        List<int>[] graph = new List<int>[n];
        bool[] seen = new bool[n];

        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        Queue<int> q = new Queue<int>();
        q.Enqueue(source);
        seen[source] = true;

        while (q.Count > 0)
        {
            int node = q.Dequeue();
            if (node == destination) return true;

            foreach (int next in graph[node])
            {
                if (seen[next]) continue;
                q.Enqueue(next);
                seen[next] = true;
            }
        }

        return false;
    }
}
