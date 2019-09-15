public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int result = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    NumIslandsInternal(grid, i, j);
                    result++;
                }
            }
        }

        return result;
    }

    private void NumIslandsInternal(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == '0')
        {
            return;
        }

        grid[i][j] = '0';
        NumIslandsInternal(grid, i - 1, j);
        NumIslandsInternal(grid, i, j - 1);
        NumIslandsInternal(grid, i + 1, j);
        NumIslandsInternal(grid, i, j + 1);
    }
}
