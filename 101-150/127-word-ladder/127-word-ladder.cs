public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        ISet<string> wordSet = new HashSet<string>(wordList);

        if (!wordSet.Contains(endWord)) return 0;

        ISet<string> first = new HashSet<string> { beginWord };
        ISet<string> second = new HashSet<string> { endWord };
        int counter = 0;

        while (first.Any() && second.Any())
        {
            counter++;

            if (first.Count > second.Count)
            {
                ISet<string> temp = first;

                first = second;
                second = temp;
            }

            ISet<string> helper = new HashSet<string>();

            foreach (string word in first)
            {
                char[] chars = word.ToCharArray();

                for (int i = 0; i < beginWord.Length; i++)
                {
                    char originalChar = chars[i];

                    for (char j = 'a'; j <= 'z'; j++)
                    {
                        if (originalChar == j) continue;

                        chars[i] = j;

                        string next = new string(chars);

                        if (second.Contains(next)) return counter + 1;

                        if (!wordSet.Contains(next)) continue;

                        wordSet.Remove(next);
                        helper.Add(next);
                    }

                    chars[i] = originalChar;
                }
            }

            first = helper;
        }

        return 0;
    }
}
