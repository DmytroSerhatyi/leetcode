public class Solution
{
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        return DFS(s, new HashSet<string>(wordDict), new Dictionary<string, IList<string>>());
    }

    private IList<string> DFS(string s, ISet<string> wordDict, IDictionary<string, IList<string>> map)
    {
        if (map.ContainsKey(s))
        {
            return map[s];
        }

        IList<string> list = new List<string>();

        if (wordDict.Contains(s))
        {
            list.Add(s);
        }

        for (int i = 1; i < s.Length; i++)
        {
            string word = s.Substring(i);

            if (wordDict.Contains(word))
            {
                IList<string> temp = DFS(s.Substring(0, i), wordDict, map);

                foreach (string t in temp)
                {
                    list.Add($"{t} {word}");
                }
            }
        }

        map[s] = list;

        return list;
    }
}
