public class Solution
{
    public int Calculate(string s)
    {
        int result = 0;
        int num = 0;
        int prev = 0;
        char sign = '+';

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (char.IsDigit(c))
            {
                num = num * 10 + (c - '0');
            }

            if ((!char.IsDigit(c) && c != ' ') || i == s.Length - 1)
            {
                switch (sign)
                {
                    case '+':
                        result += prev;
                        prev = num;
                        break;
                    case '-':
                        result += prev;
                        prev = -num;
                        break;
                    case '*':
                        prev *= num;
                        break;
                    case '/':
                        prev /= num;
                        break;
                }

                sign = c;
                num = 0;
            }
        }

        return result += prev;
    }
}
