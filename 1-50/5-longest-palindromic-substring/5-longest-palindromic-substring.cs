public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length == 0) return "";

        string result = s.Substring(0, 1);

        for (int i = 2; i < 4 && i <= s.Length; i++)
        {
            for (int j = 0; j + i <= s.Length; j++)
            {
                int iHelp = i;
                int jHelp = j;

                while (iHelp <= s.Length - jHelp && jHelp >= 0 && s[jHelp] == s[jHelp + iHelp - 1])
                {
                    string substr = s.Substring(jHelp, iHelp);

                    if (substr.Length > result.Length)
                    {
                        result = substr;

                        if (result.Length == s.Length) return result;
                    }

                    iHelp += 2;
                    jHelp--;
                }
            }
        }

        return result;
    }
}
