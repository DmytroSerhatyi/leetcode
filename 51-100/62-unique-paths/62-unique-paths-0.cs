public class Solution
{
    public int UniquePaths(int m, int n)
    {
        return UniquePathsInternal(m, n, new int?[m + 1, n + 1]);
    }

    private int UniquePathsInternal(int m, int n, int?[,] helper)
    {
        if (helper[m, n] != null) return helper[m, n].Value;

        if (m == 1 || n == 1) return 1;

        int val = UniquePathsInternal(m - 1, n, helper) + UniquePathsInternal(m, n - 1, helper);

        helper[m, n] = val;

        return val;
    }
}
