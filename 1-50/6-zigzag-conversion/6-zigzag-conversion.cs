public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows < 2) return s;

        int step = numRows * 2 - 2;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < numRows; i++)
        {
            for (int j = i; j < s.Length; j += step)
            {
                result.Append(s[j]);

                if (i == 0 || i == numRows - 1) continue;

                int k = step + j - 2 * i;

                if (k < s.Length) result.Append(s[k]);
            }
        }

        return result.ToString();
    }
}
