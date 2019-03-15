public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>
        {
            new List<int>()
        };

        for (int i = 1; i <= nums.Length; i++) SubsetsInternal(result, nums, new int[i], 0, 0);

        return result;
    }

    public void SubsetsInternal(IList<IList<int>> res, int[] nums, int[] helper, int index, int start)
    {
        if (index == helper.Length)
        {
            res.Add(new List<int>(helper));
            return;
        }

        for (int i = start; i < nums.Length - helper.Length + index + 1; i++)
        {
            helper[index] = nums[i];
            SubsetsInternal(res, nums, helper, index + 1, i + 1);
        }
    }
}
