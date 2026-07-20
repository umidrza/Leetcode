namespace Leetcode.src.Solutions.Array;

// https://leetcode.com/problems/shift-2d-grid
public class Shift2DGrid
{
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int total = m * n;

        int[][] shifted = new int[m][];
        for (int i = 0; i < m; i++)
            shifted[i] = new int[n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int idx = i * n + j;
                int newIdx = (idx + k) % total;

                int newRow = newIdx / n;
                int newCol = newIdx % n;

                shifted[newRow][newCol] = grid[i][j];
            }
        }

        IList<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < m; i++)
        {
            result.Add(new List<int>(shifted[i]));
        }

        return result;
    }
}
