public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length < 2) return s;

        int fil = 0;
        int fir = 0;
        int cl = 0;
        int cr = 0;
        int l = 0;
        int sl, sr;

        while (cl < s.Length && cr < s.Length)
        {
            while (cr < s.Length && s[cl] == s[cr]) cr++;

            sl = cl - 1;
            sr = cr;

            while (sl >= 0 && sr < s.Length && s[sl] == s[sr])
            {
                sl--;
                sr++;
            }

            int tempL = sr - sl + 1;

            if (tempL > l)
            {
                l = tempL;
                fil = sl + 1;
                fir = sr;
            }

            cl = cr;
        }

        return s.Substring(fil, fir - fil);
    }
}
