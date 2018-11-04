public class Solution
{
    public int MyAtoi(string str)
    {
        str = str.Trim();

        if (string.IsNullOrEmpty(str)) return 0;

        int sign = 1;
        long result = 0;
        int index = 0;

        if (str[0] == '+' || str[0] == '-')
        {
            sign = str[0] == '+' ? 1 : -1;
            index++;
        }

        while (index < str.Length)
        {
            if (!char.IsNumber(str[index])) break;

            result = result * 10 + str[index] - '0';

            if (result * sign > int.MaxValue) return int.MaxValue;
            if (result * sign < int.MinValue) return int.MinValue;

            index++;
        }

        return (int)result * sign;
    }
}
