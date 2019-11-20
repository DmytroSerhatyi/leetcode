public class Solution
{
    public int MaximalSquare(char[][] matrix)
    {
        int rows = matrix.Length;
        int cols = rows > 0 ? matrix[0].Length : 0;
        int[] dp = new int[cols + 1];
        int side = 0;
        int prev = 0;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= cols; j++)
            {
                int temp = dp[j];

                if (matrix[i - 1][j - 1] == '1')
                {
                    dp[j] = Math.Min(Math.Min(dp[j - 1], prev), dp[j]) + 1;
                    side = Math.Max(side, dp[j]);
                }
                else
                {
                    dp[j] = 0;
                }

                prev = temp;
            }
        }

        return side * side;
    }
}
