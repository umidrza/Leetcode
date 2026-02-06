namespace Leetcode.src.Solutions.BFS;

// https://leetcode.com/problems/map-of-highest-peak
public class MapOfHighestPeak
{
    public int[][] HighestPeak(int[][] isWater)
    {
        int m = isWater.Length, n = isWater[0].Length;
        int[] dirs = new int[] { 0, 1, 0, -1, 0 };
        Queue<(int, int)> q = new Queue<(int, int)>();
        bool[][] seen = new bool[m][];
        int[][] res = new int[m][];

        for (int i = 0; i < m; i++)
        {
            res[i] = new int[n];
            seen[i] = new bool[n];
            for (int j = 0; j < n; j++)
            {
                if (isWater[i][j] == 1)
                {
                    q.Enqueue((i, j));
                    seen[i][j] = true;
                }
            }
        }

        int height = 0;
        while (q.Count > 0)
        {
            int count = q.Count;
            for (int i = 0; i < count; i++)
            {
                var (x, y) = q.Dequeue();
                res[x][y] = height;

                for (int j = 0; j < 4; j++)
                {
                    int nx = x + dirs[j];
                    int ny = y + dirs[j + 1];

                    if (nx >= 0 && ny >= 0 && nx < m && ny < n && !seen[nx][ny])
                    {
                        q.Enqueue((nx, ny));
                        seen[nx][ny] = true;
                    }
                }
            }
            height++;
        }

        return res;
    }
}
