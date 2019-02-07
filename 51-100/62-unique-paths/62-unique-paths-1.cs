public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[,] calculations = new int[m, n];

        for (int i = 0; i < m; i++) calculations[i, 0] = 1;

        for (int i = 0; i < n; i++) calculations[0, i] = 1;

        for (int i = 1; i < m; i++) for (int j = 1; j < n; j++) calculations[i, j] = calculations[i - 1, j] + calculations[i, j - 1];

        return calculations[m - 1, n - 1];
    }
}
