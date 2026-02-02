namespace Leetcode.src.Solutions.Graph;

// https://leetcode.com/problems/minimum-number-of-vertices-to-reach-all-nodes
public class MinimumNumberOfVerticesToReachAllNodes
{
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
    {
        var res = new List<int>();
        bool[] canReach = new bool[n];

        foreach (var edge in edges)
        {
            canReach[edge[1]] = true;
        }

        for (int i = 0; i < n; i++)
        {
            if (!canReach[i])
                res.Add(i);
        }

        return res;
    }
}
