public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> helper = new Dictionary<string, IList<string>>();

        foreach (string str in strs)
        {
            char[] temp = str.ToCharArray();

            Array.Sort(temp);

            string sortedStr = new string(temp);

            if (!helper.ContainsKey(sortedStr)) helper.Add(sortedStr, new List<string>());

            helper[sortedStr].Add(str);
        }

        IList<IList<string>> result = new List<IList<string>>();

        foreach (KeyValuePair<string, IList<string>> entry in helper) result.Add(entry.Value);

        return result;
    }
}
