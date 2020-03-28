public class Solution
{
    public IList<IList<string>> FindLadders(string beginWord, string endWord, IList<string> wordList)
    {
        IList<IList<string>> result = new List<IList<string>>();

        if (beginWord == null || endWord == null || beginWord == endWord)
        {
            return result;
        }

        HashSet<string> wordSet = new HashSet<string>(wordList);

        if (!wordSet.Contains(endWord))
        {
            return result;
        }

        Dictionary<string, List<string>> wordMap = new Dictionary<string, List<string>>();
        HashSet<string> startSet = new HashSet<string> { beginWord };
        HashSet<string> endSet = new HashSet<string> { endWord };

        GetAllPathsBFS(startSet, endSet, wordMap, wordSet, false);

        IList<string> path = new List<string> { beginWord };

        GetLaddersDFS(beginWord, endWord, wordMap, result, path);

        return result;
    }

    public void GetAllPathsBFS(HashSet<string> startSet, HashSet<string> endSet, Dictionary<string, List<string>> wordMap, HashSet<string> wordSet, bool isReverse)
    {
        if (startSet.Count == 0)
        {
            return;
        }

        if (startSet.Count > endSet.Count)
        {
            GetAllPathsBFS(endSet, startSet, wordMap, wordSet, !isReverse);

            return;
        }

        bool isEnd = false;
        HashSet<string> temp = new HashSet<string>();

        wordSet.ExceptWith(startSet);

        foreach (string str in startSet)
        {
            char[] wordArray = str.ToCharArray();

            for (int index = 0; index < wordArray.Length; index++)
            {
                char originalChar = wordArray[index];

                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (c == originalChar)
                    {
                        continue;
                    }

                    wordArray[index] = c;

                    string newStr = new string(wordArray);

                    if (wordSet.Contains(newStr))
                    {
                        if (endSet.Contains(newStr))
                        {
                            isEnd = true;
                        }
                        else
                        {
                            temp.Add(newStr);
                        }

                        string key = isReverse ? newStr : str;
                        string val = isReverse ? str : newStr;

                        if (!wordMap.ContainsKey(key))
                        {
                            wordMap.Add(key, new List<string>());
                        }

                        List<string> list = wordMap[key];

                        if (!list.Contains(val))
                        {
                            list.Add(val);
                            wordMap[key] = list;
                        }
                    }

                    wordArray[index] = originalChar;
                }
            }
        }

        if (!isEnd)
        {
            GetAllPathsBFS(temp, endSet, wordMap, wordSet, isReverse);
        }
    }

    public void GetLaddersDFS(string begin, string end, Dictionary<string, List<string>> wordMap, IList<IList<string>> result, IList<string> path)
    {
        if (begin.Equals(end))
        {
            result.Add(new List<string>(path));

            return;
        }

        if (wordMap.ContainsKey(begin))
        {
            if (wordMap[begin] == null)
            {
                return;
            }

            foreach (string next in wordMap[begin])
            {
                path.Add(next);
                GetLaddersDFS(next, end, wordMap, result, path);
                path.RemoveAt(path.Count - 1);
            }
        }
    }
}
