public class Solution
{
    public string FractionToDecimal(int numerator, int denominator)
    {
        long n = numerator;
        long d = denominator;
        long num = n / d;
        long remainder = n % d;

        if (remainder == 0)
        {
            return num.ToString();
        }

        StringBuilder result = new StringBuilder();
        Dictionary<long, int> map = new Dictionary<long, int>();

        if ((numerator < 0 && denominator >= 0) || (numerator >= 0 && denominator < 0))
        {
            result.Append('-');
            num = Math.Abs(num);
            d = Math.Abs(d);
            remainder = Math.Abs(remainder);
        }

        result.Append(num);
        result.Append('.');

        while (remainder != 0)
        {
            remainder *= 10;

            if (map.ContainsKey(remainder))
            {
                int i = map[remainder];

                result.Insert(i, '(');
                result.Append(')');

                return result.ToString();
            }

            map.Add(remainder, result.Length);

            long temp = remainder / d;

            result.Append(temp);
            remainder %= d;
        }

        return result.ToString();
    }
}
