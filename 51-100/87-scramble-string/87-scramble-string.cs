public class Solution
{
    public bool IsScramble(string s1, string s2)
    {
        int l1 = s1.Length;
        int l2 = s2.Length;

        if (l1 == 0)
        {
            return true;
        }

        if (s1 == s2)
        {
            return true;
        }

        Dictionary<char, int> chars = new Dictionary<char, int>();

        foreach (char c in s1)
        {
            if (chars.ContainsKey(c))
            {
                chars[c]++;
            }
            else
            {
                chars[c] = 1;
            }
        }

        foreach (char c in s2)
        {
            if (chars.ContainsKey(c))
            {
                chars[c]--;
            }
            else
            {
                return false;
            }
        }

        if (chars.Any(kvp => kvp.Value != 0))
        {
            return false;
        }

        for (int i = 1; i < l1; i++)
        {
            if (IsScramble(s1.Substring(0, i), s2.Substring(0, i)) && IsScramble(s1.Substring(i), s2.Substring(i))
                || IsScramble(s1.Substring(0, i), s2.Substring(l1 - i)) && IsScramble(s1.Substring(i), s2.Substring(0, l1 - i)))
            {
                return true;
            }
        }

        return false;
    }
}
