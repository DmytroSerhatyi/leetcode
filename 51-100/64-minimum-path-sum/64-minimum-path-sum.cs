public class Solution
{
    public int MinPathSum(int[,] grid)
    {
        int m = grid.GetLength(0);
        int n = grid.GetLength(1);
        int i;

        for (i = 1; i < m; i++) grid[i, 0] += grid[i - 1, 0];

        for (i = 1; i < n; i++) grid[0, i] += grid[0, i - 1];

        for (i = 1; i < m; i++) for (int j = 1; j < n; j++) grid[i, j] += Math.Min(grid[i - 1, j], grid[i, j - 1]);

        return grid[m - 1, n - 1];
    }
}
