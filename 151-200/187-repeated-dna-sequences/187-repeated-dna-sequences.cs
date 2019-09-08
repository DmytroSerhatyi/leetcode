public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        Dictionary<string, int> store = new Dictionary<string, int>();

        for (int i = 0; i < s.Length - 9; i++)
        {
            string sub = s.Substring(i, 10);

            if (store.ContainsKey(sub))
            {
                store[sub] += 1;
            }
            else
            {
                store.Add(sub, 1);
            }
        }

        IList<string> result = new List<string>();

        foreach (KeyValuePair<string, int> val in store)
        {
            if (val.Value > 1)
            {
                result.Add(val.Key);
            }
        }

        return result;
    }
}
