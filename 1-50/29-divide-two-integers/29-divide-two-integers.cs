public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == 0) return 0;

        bool isPositive = ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0));
        long ldividend = Math.Abs((long)dividend);
        long ldivisor = Math.Abs((long)divisor);
        int bitshift = 1;

        while (ldividend >= (ldivisor << bitshift)) bitshift++;

        long result = 0;

        for (int i = bitshift - 1; i >= 0; i--)
        {
            long tempLdivisor = ldivisor << i;

            if (ldividend < tempLdivisor) continue;

            result += (1 << i);
            ldividend -= tempLdivisor;

            if (ldividend == 0) break;
        }

        if (isPositive)
        {
            if (result < 0) return int.MaxValue;
        }
        else
        {
            result = -result;
        }

        return (int)result;
    }
}
