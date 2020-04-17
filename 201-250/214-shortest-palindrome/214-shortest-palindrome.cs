public class Solution
{
    public string ShortestPalindrome(string s)
    {
        int l = 0;
        int r = s.Length - 1;
        StringBuilder result = new StringBuilder();

        while (l < r)
        {
            if (s[l] == s[r])
            {
                l++;
                r--;

                continue;
            }

            result.Append(s[s.Length - result.Length - 1]);

            for (int i = r, j = l - 1; j >= 0; j--)
            {
                if (s[i] == s[j])
                {
                    i++;

                    continue;
                }

                result.Append(s[s.Length - result.Length - 1]);

                // rewrite left and right
                l = j;
                r = i;
            }

            r--;
        }

        return result.Append(s).ToString();
    }
}
