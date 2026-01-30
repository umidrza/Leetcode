namespace Leetcode.src.Solutions.Backtracking;

// https://leetcode.com/problems/all-paths-from-source-to-target
public class AllPathsFromSourceToTarget
{
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var res = new List<IList<int>>();
        Backtrack(0, new List<int>(), res, graph);
        return res;
    }

    void Backtrack(int node, List<int> path, List<IList<int>> res, int[][] graph)
    {
        path.Add(node);

        if (node == graph.Length - 1)
        {
            res.Add([.. path]);
        }
        else
        {
            foreach (int next in graph[node])
            {
                Backtrack(next, path, res, graph);
            }
        }

        path.RemoveAt(path.Count - 1);
    }
}
