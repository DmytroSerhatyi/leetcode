public class Solution
{
    public int NumSquares(int n)
    {
        int[] helper = new int[n + 1];

        Array.Fill(helper, n);

        for (int i = 0; i <= n; i++)
        {
            if (i * i <= n)
            {
                helper[i * i] = 1;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j * j <= i; j++)
            {
                if (i + j * j <= n)
                {
                    helper[i + j * j] = Math.Min(helper[i + j * j], helper[i] + 1);
                }
            }
        }

        return helper[n];
    }
}
