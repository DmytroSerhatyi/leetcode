public class Solution
{
    public int NumDecodings(string s)
    {
        if (s.Length == 0 || s[0] == '0') return 0;

        int previous = 1;
        int current = 1;

        for (int i = 2; i <= s.Length; i++)
        {
            int num = 0;
            int first = s[i - 1] - '0';
            int second = (s[i - 2] - '0') * 10 + first;

            if (first > 0 && first < 10) num += current;

            if (second >= 10 && second <= 26) num += previous;

            previous = current;
            current = num;
        }

        return current;
    }
}
