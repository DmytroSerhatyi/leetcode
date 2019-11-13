public class Solution
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        IList<IList<int>> result = new List<IList<int>>();

        if (k > 0 && n > 0)
        {
            CombinationSum3Internal(result, new List<int>(), k, n, 1);
        }

        return result;
    }

    public void CombinationSum3Internal(IList<IList<int>> result, IList<int> temp, int k, int n, int i)
    {
        if (k == 0)
        {
            if (n == 0)
            {
                result.Add(new List<int>(temp));
            }

            return;
        }

        while (i <= n && i < 10)
        {
            temp.Add(i);
            CombinationSum3Internal(result, temp, k - 1, n - i, i + 1);
            temp.RemoveAt(temp.Count - 1);
            i++;
        }
    }
}
