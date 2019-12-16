public class Solution
{
    public int NthUglyNumber(int n)
    {
        int[] helper = new int[n];
        int i2 = 0;
        int i3 = 0;
        int i5 = 0;
        int n2 = 2;
        int n3 = 3;
        int n5 = 5;

        helper[0] = 1;

        for (int i = 1; i < n; i++)
        {
            helper[i] = Math.Min(n2, Math.Min(n3, n5));

            if (n2 == helper[i])
            {
                n2 = 2 * helper[++i2];
            }

            if (n3 == helper[i])
            {
                n3 = 3 * helper[++i3];
            }

            if (n5 == helper[i])
            {
                n5 = 5 * helper[++i5];
            }
        }

        return helper[n - 1];
    }
}
