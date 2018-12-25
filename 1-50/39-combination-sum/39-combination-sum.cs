public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();

        FindCombinations(candidates, target, result, new List<int>(), 0, 0);

        return result;
    }

    private void FindCombinations(int[] candidates, int target, IList<IList<int>> res, IList<int> candidate, int sum, int index)
    {
        if (sum == target)
        {
            res.Add(new List<int>(candidate));

            return;
        }

        if (sum > target) return;

        for (int i = index; i < candidates.Length; i++)
        {
            candidate.Add(candidates[i]);
            FindCombinations(candidates, target, res, candidate, sum + candidates[i], i);
            candidate.RemoveAt(candidate.Count - 1);
        }
    }
}
