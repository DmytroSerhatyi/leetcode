public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        bool[] checkings = new bool[s.Length + 1];

        checkings[0] = true;

        for (int i = 0; i <= s.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (checkings[i])
                {
                    break;
                }

                checkings[i] = checkings[j] && wordDict.Contains(s.Substring(j, i - j));
            }
        }

        return checkings[s.Length];
    }
}
