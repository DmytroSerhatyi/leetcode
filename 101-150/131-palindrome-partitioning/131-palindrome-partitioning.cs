public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> result = new List<IList<string>>();

        PartitionInternal(result, new List<string>(), s, 0);

        return result;
    }

    private void PartitionInternal(IList<IList<string>> store, IList<string> helper, string s, int index)
    {
        if (index >= s.Length)
        {
            store.Add(new List<string>(helper));

            return;
        }

        for (int length = 1; length <= s.Length - index; length++)
        {
            if (IsPalindrome(s, index, length + index - 1))
            {
                helper.Add(s.Substring(index, length));
                PartitionInternal(store, helper, s, index + length);
                helper.RemoveAt(helper.Count - 1);
            }
        }
    }

    private bool IsPalindrome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start++] != s[end--])
            {
                return false;
            }
        }

        return true;
    }
}
