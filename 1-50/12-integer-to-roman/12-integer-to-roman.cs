public class Solution
{
    public string IntToRoman(int num)
    {
        StringBuilder result = new StringBuilder();
        var map = new[]
        {
            new { num = 1000, symbol = 'M' },
            new { num = 500, symbol = 'D' },
            new { num = 100, symbol = 'C' },
            new { num = 50, symbol = 'L' },
            new { num = 10, symbol = 'X' },
            new { num = 5, symbol = 'V' },
            new { num = 1, symbol = 'I' }
        };
        int current = 0;

        while (num > 0)
        {
            if (num < map[current].num)
            {
                int next = current % 2 == 0 ? current + 2 : current + 1;

                if (num >= map[current].num - map[next].num)
                {
                    result.Append(map[next].symbol);
                    result.Append(map[current].symbol);
                    num -= map[current].num - map[next].num;
                }

                current++;
                continue;
            }
            else
            {
                result.Append(map[current].symbol);
                num -= map[current].num;
            }
        }

        return result.ToString();
    }
}
