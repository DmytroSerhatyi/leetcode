public class Solution
{
    public int MaxPoints(int[][] points)
    {
        if (points.Length < 2)
        {
            return points.Length;
        }

        int result = 2;

        foreach (int[] point1 in points)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int tempResult = 0;

            foreach (int[] point2 in points)
            {
                int num = point2[1] - point1[1];
                int den = point2[0] - point1[0];
                int sign = (num > 0 && den < 0) || (num < 0 && den > 0) ? -1 : 1;

                num = Math.Abs(num);
                den = Math.Abs(den);

                int gcd = GCD(num, den);

                num = gcd == 0 ? num : num / gcd;
                den = gcd == 0 ? den : den / gcd;

                int m = sign * (num + den) * (num + den + 1) / 2 + den;

                if (map.ContainsKey(m))
                {
                    map[m]++;
                }
                else
                {
                    map[m] = 1;
                }

                if (m == 0)
                {
                    continue;
                }

                tempResult = Math.Max(map[m], tempResult);
            }

            result = Math.Max(result, tempResult + map[0]);
        }

        return result;
    }

    private int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }

        return GCD(b, a % b);
    }
}
