public class Solution
{
    public string MinWindow(string s, string t)
    {
        int b = 0;
        int br = 0;
        int er = int.MaxValue;
        int l = 0;
        Dictionary<char, int> chars = new Dictionary<char, int>();

        for (int i = 0; i < t.Length; i++)
        {
            if (!chars.ContainsKey(t[i]))
            {
                chars.Add(t[i], 1);
            }
            else
            {
                chars[t[i]]++;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (!chars.ContainsKey(s[i]))
            {
                continue;
            }

            if (--chars[s[i]] == 0 && ++l == chars.Count())
            {
                while (true)
                {
                    if (!chars.ContainsKey(s[b]))
                    {
                        b++;
                    }
                    else if (chars[s[b]] < 0)
                    {
                        chars[s[b]]++;
                        b++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (i - b < er - br)
                {
                    br = b;
                    er = i;
                }

                chars[s[b++]]++;
                l--;
            }
        }

        return er != int.MaxValue ? s.Substring(br, er - br + 1) : string.Empty;
    }
}
