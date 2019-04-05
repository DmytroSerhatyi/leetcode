public class Solution
{
    public int NumTrees(int n)
    {
        if (n < 2) return 1;

        int[] helper = new int[n + 1];

        helper[0] = helper[1] = 1;

        for (int i = 2; i <= n; i++) for (int j = 1; j <= i; j++) helper[i] += helper[j - 1] * helper[i - j];

        return helper[n];
    }
}
