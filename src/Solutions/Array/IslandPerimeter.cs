namespace Leetcode.src.Solutions.Array;

// https://leetcode.com/problems/island-perimeter
public class IslandPerimeterSolution
{
    public int IslandPerimeter(int[][] grid)
    {
        int rows = grid.Length, cols = grid[0].Length;
        int[] dirs = { 0, 1, 0, -1, 0 };
        int perimeter = 0;

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        int nr = r + dirs[i];
                        int nc = c + dirs[i + 1];

                        if (nr < 0 || nr >= rows || nc < 0 || nc >= cols || grid[nr][nc] == 0)
                        {
                            perimeter++;
                        }
                    }
                }
            }
        }

        return perimeter;
    }
}
