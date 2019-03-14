public class Solution
{
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> result = new List<IList<int>>();
        int[] target = new int[k];

        CombineInternal(result, target, 0, 1, n - k + 1);

        return result;
    }

    private void CombineInternal(IList<IList<int>> res, int[] target, int index, int begin, int step)
    {
        if (index == target.Length)
        {
            res.Add(new List<int>(target));
            return;
        }

        for (int i = begin; i <= step + index; i++)
        {
            target[index] = i;
            CombineInternal(res, target, index + 1, i + 1, step);
        }
    }
}
