public class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0) return 1;

        bool isNegative = n < 0;
        long ln = n;
        List<double> helper = new List<double>();

        ln = Math.Abs(ln);

        while (ln > 1)
        {
            if (ln % 2 == 1) helper.Add(x);

            x *= x;
            ln /= 2;
        }

        foreach (double number in helper) x *= number;

        return isNegative ? 1 / x : x;
    }
}
