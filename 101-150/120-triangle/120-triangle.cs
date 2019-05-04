public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        if (triangle == null || triangle.Count == 0) return 0;

        IList<IList<int>> helper = new List<IList<int>> { new List<int> { triangle[0][0] } };

        for (int i = 1; i < triangle.Count; i++)
        {
            IList<int> prev = helper[i - 1];
            IList<int> current = triangle[i];
            IList<int> helperRow = new List<int> { current.First() + prev.First() };

            for (int j = 1; j < current.Count - 1; j++) helperRow.Add(current[j] + Math.Min(prev[j - 1], prev[j]));

            helperRow.Add(current.Last() + prev.Last());
            helper.Add(helperRow);
        }

        return helper.Last().Min();
    }
}
