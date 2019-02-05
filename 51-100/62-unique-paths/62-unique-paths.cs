public class Solution
{
    public int UniquePaths(int m, int n)
    {
        if (m <= 0 || n <= 0) return 0;

        if (m == 1 || n == 1) return 1;

        int[] helper = new int[m];
        int i;

        for (i = 0; i < m; i++) helper[i] = i + 1;

        i = 2;

        while (i < n)
        {
            for (int j = 1; j < helper.Length; j++) helper[j] += helper[j - 1];
            i++;
        }

        return helper[helper.Length - 1];
    }
}
