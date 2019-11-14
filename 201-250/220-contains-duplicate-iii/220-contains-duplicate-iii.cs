public class Solution
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {
        var n = nums.Select((num, index) => new { num, index }).OrderBy(i => i.num).ToArray();

        for (int i = 0; i < n.Length; i++)
        {
            for (int j = i + 1; j < n.Length && n[j].num - (long)n[i].num <= t; j++)
            {
                if (Math.Abs(n[i].index - n[j].index) <= k)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
