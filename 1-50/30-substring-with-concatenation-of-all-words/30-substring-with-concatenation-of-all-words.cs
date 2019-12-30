public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        List<int> result = new List<int>();

        if (s == null || s.Length == 0 || words == null || words.Length == 0)
        {
            return result;
        }

        int count = words.Length;
        int wordLength = words[0].Length;
        int maxStart = s.Length - count * wordLength;
        Dictionary<string, int> map = new Dictionary<string, int>();
        Queue<string> queue = new Queue<string>();

        foreach (string word in words)
        {
            if (!map.ContainsKey(word))
            {
                map.Add(word, 0);
            }

            map[word]++;
        }

        for (int i = 0; i < wordLength; i++)
        {
            while (queue.Count > 0)
            {
                map[queue.Dequeue()]++;
            }

            int position = i;

            for (int start = i; start <= maxStart; position += wordLength)
            {
                string word = s.Substring(position, wordLength);

                if (!map.ContainsKey(word))
                {
                    while (queue.Count > 0)
                    {
                        map[queue.Dequeue()]++;
                    }

                    start = position + wordLength;

                    continue;
                }

                map[word]--;
                queue.Enqueue(word);

                while (map[word] < 0)
                {
                    map[queue.Dequeue()]++;
                    start += wordLength;
                }

                if (queue.Count == count)
                {
                    result.Add(start);
                    map[queue.Dequeue()]++;
                    start += wordLength;
                }
            }
        }

        return result;
    }
}
