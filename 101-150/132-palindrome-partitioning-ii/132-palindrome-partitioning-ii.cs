public class Solution
{
    public int MinCut(string s)
    {
        int[] cuts = new int[s.Length + 1];

        for (int i = 0; i <= s.Length; i++)
        {
            cuts[i] = i - 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j <= i && i + j < s.Length; j++)
            {
                if (s[i - j] == s[i + j])
                {
                    cuts[i + j + 1] = Math.Min(cuts[i + j + 1], cuts[i - j] + 1);
                }
                else
                {
                    break;
                }
            }

            for (int j = 1; j <= i + 1 && i + j < s.Length; j++)
            {
                if (s[i - j + 1] == s[i + j])
                {
                    cuts[i + j + 1] = Math.Min(cuts[i + j + 1], cuts[i - j + 1] + 1);
                }
                else
                {
                    break;
                }
            }
        }

        return cuts[s.Length];
    }
}
