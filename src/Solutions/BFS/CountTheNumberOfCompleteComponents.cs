namespace Leetcode.src.Solutions.BFS;

// https://leetcode.com/problems/count-the-number-of-complete-components
public class CountTheNumberOfCompleteComponents
{
    public int CountCompleteComponents(int n, int[][] edges)
    {
        List<int>[] graph = new List<int>[n];
        Queue<int> q = new Queue<int>();
        bool[] seen = new bool[n];
        int res = 0;

        for (int i = 0; i < n; i++)
        {
            graph[i] = new List<int>();
        }

        foreach (int[] edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        for (int i = 0; i < n; i++)
        {
            if (seen[i]) continue;
            int nodeCount = 0, edgeCount = 0;
            q.Enqueue(i);

            while (q.Count > 0)
            {
                int node = q.Dequeue();
                if (seen[node]) continue;
                seen[node] = true;
                nodeCount++;

                foreach (int next in graph[node])
                {
                    if (seen[next]) continue;
                    q.Enqueue(next);
                    edgeCount++;
                }
            }

            if (edgeCount == nodeCount * (nodeCount - 1) / 2)
                res++;
        }

        return res;
    }
}
