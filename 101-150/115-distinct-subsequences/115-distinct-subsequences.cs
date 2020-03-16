public class Solution
{
    public int NumDistinct(string s, string t)
    {
        int[] dp = new int[t.Length + 1];

        dp[0] = 1;

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = t.Length - 1; j >= 0; j--)
            {
                if (s[i] == t[j])
                {
                    dp[j + 1] += dp[j];
                }
            }
        }

        return dp[t.Length];
    }
}
