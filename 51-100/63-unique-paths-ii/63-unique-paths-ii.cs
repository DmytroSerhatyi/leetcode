public class Solution
{
    public int UniquePathsWithObstacles(int[,] obstacleGrid)
    {
        if (obstacleGrid[0, 0] == 1) return 0;

        int m = obstacleGrid.GetLength(0);
        int n = obstacleGrid.GetLength(1);
        int i;

        obstacleGrid[0, 0] = 1;

        for (i = 1; i < m; i++) obstacleGrid[i, 0] = obstacleGrid[i, 0] == 0 && obstacleGrid[i - 1, 0] == 1 ? 1 : 0;

        for (i = 1; i < n; i++) obstacleGrid[0, i] = obstacleGrid[0, i] == 0 && obstacleGrid[0, i - 1] == 1 ? 1 : 0;

        for (i = 1; i < m; i++) for (int j = 1; j < n; j++) obstacleGrid[i, j] = obstacleGrid[i, j] == 1 ? 0 : obstacleGrid[i - 1, j] + obstacleGrid[i, j - 1];

        return obstacleGrid[m - 1, n - 1];
    }
}
