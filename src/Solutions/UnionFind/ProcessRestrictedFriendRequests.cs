namespace Leetcode.src.Solutions.UnionFind;

// https://leetcode.com/problems/process-restricted-friend-requests
public class ProcessRestrictedFriendRequests
{
    public bool[] FriendRequests(int n, int[][] restrictions, int[][] requests)
    {
        var res = new bool[requests.Length];

        int[] parent = new int[n];
        for (int i = 0; i < n; i++)
            parent[i] = i;

        for (int i = 0; i < requests.Length; i++)
        {
            int u = requests[i][0], v = requests[i][1];

            int rootU = Find(parent, u);
            int rootV = Find(parent, v);

            if (rootU == rootV)
            {
                res[i] = true;
                continue;
            }

            bool canAccept = true;
            foreach (int[] r in restrictions)
            {
                int rootX = Find(parent, r[0]);
                int rootY = Find(parent, r[1]);

                if ((rootX == rootU && rootY == rootV) || (rootX == rootV && rootY == rootU))
                {
                    canAccept = false;
                    break;
                }
            }

            if (canAccept)
            {
                parent[rootV] = rootU;
                res[i] = true;
            }
        }

        return res;
    }

    private int Find(int[] parent, int x)
    {
        if (parent[x] != x)
            parent[x] = Find(parent, parent[x]);
        return parent[x];
    }
}
