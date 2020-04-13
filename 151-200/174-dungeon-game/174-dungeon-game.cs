public class Solution
{
    public int CalculateMinimumHP(int[][] dungeon)
    {
        int rows = dungeon.Length;
        int cols = dungeon[0].Length;
        int[,] dp = new int[rows, cols];

        dp[rows - 1, cols - 1] = Math.Max(1, 1 - dungeon[rows - 1][cols - 1]);

        for (int i = cols - 2; i >= 0; i--)
        {
            dp[rows - 1, i] = Math.Max(1, dp[rows - 1, i + 1] - dungeon[rows - 1][i]);
        }

        for (int i = rows - 2; i >= 0; i--)
        {
            dp[i, cols - 1] = Math.Max(1, dp[i + 1, cols - 1] - dungeon[i][cols - 1]);
        }

        for (int i = rows - 2; i >= 0; i--)
        {
            for (int j = cols - 2; j >= 0; j--)
            {
                SetMin(i, j, dp, dungeon[i][j]);
            }
        }

        return dp[0, 0];
    }

    private void SetMin(int row, int col, int[,] dp, int target)
    {
        int right = Math.Max(1, dp[row, col + 1] - target);
        int minDown = Math.Max(1, dp[row + 1, col] - target);

        dp[row, col] = Math.Min(right, minDown);
    }
}
