namespace Leetcode.src.Solutions.BFS;

// https://leetcode.com/problems/all-paths-from-source-to-target
public class AllPathsFromSourceToTarget
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        int target = graph.Length - 1;
        var res = new List<IList<int>>();
        var q = new Queue<List<int>>();
        q.Enqueue([0]);

        while (q.Count > 0)
        {
            List<int> path = q.Dequeue();
            int node = path[^1];
            if (node == target)
            {
                res.Add([.. path]);
            }

            foreach (int next in graph[node])
            {
                q.Enqueue([.. path, next]);
            }
        }

        return res;
    }
}
