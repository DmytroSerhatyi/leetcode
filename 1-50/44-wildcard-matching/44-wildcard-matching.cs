public class Solution
{
    public bool IsMatch(string s, string p)
    {
        int sIndex = 0;
        int pIndex = 0;
        int startIndex = -1;
        int preMathIndex = -1;

        while (sIndex < s.Length)
        {
            if (pIndex < p.Length && (s[sIndex] == p[pIndex] || p[pIndex] == '?'))
            {
                sIndex++;
                pIndex++;
            }
            else if (pIndex < p.Length && p[pIndex] == '*')
            {
                startIndex = pIndex;
                pIndex++;
                preMathIndex = sIndex;
            }
            else if (startIndex >= 0)
            {
                pIndex = startIndex + 1;
                preMathIndex++;
                sIndex = preMathIndex;
            }
            else
            {
                return false;
            }
        }

        while (pIndex < p.Length && p[pIndex] == '*')
        {
            pIndex++;
        }

        return pIndex == p.Length;
    }
}
