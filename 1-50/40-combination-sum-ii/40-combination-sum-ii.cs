public class Solution
{
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();

        Array.Sort(candidates);
        FindCombinations(candidates, target, result, new List<int>(), 0);

        return result;
    }

    private void FindCombinations(int[] candidates, int target, IList<IList<int>> res, IList<int> candidate, int index)
    {
        if (target == 0) res.Add(new List<int>(candidate));
        else if (target > 0)
        {
            for (int i = index; i < candidates.Length; i++)
            {
                if (candidates[i] > target) break;

                candidate.Add(candidates[i]);
                FindCombinations(candidates, target - candidates[i], res, candidate, i + 1);
                candidate.RemoveAt(candidate.Count - 1);

                while (i < candidates.Length - 1 && candidates[i] == candidates[i + 1]) i++;
            }
        }
    }
}
