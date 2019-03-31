public class Solution
{
    public IList<string> RestoreIpAddresses(string s)
    {
        IList<string> result = new List<string>();

        CheckIPs(result, new int[4], s, 0, 0);

        return result;
    }

    public void CheckIPs(IList<string> res, int[] store, string s, int start, int parts)
    {
        if (parts == 4)
        {
            if (start == s.Length) res.Add(string.Join('.', store));

            return;
        }

        for (int l = 1; l <= 3; l++)
        {
            int count = 0;
            int num = 0;

            while (count < l)
            {
                if (start + count >= s.Length || (count > 0 && num == 0)) return;

                num = num * 10 + (s[start + count] - '0');
                count++;
            }

            if (num < 256)
            {
                store[parts] = num;
                CheckIPs(res, store, s, start + l, parts + 1);
            }
        }
    }
}
