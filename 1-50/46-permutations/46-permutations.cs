public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();

        PermuteInternal(nums, 0, result);

        return result;
    }

    private void PermuteInternal(int[] nums, int index, IList<IList<int>> res)
    {
        if (index == nums.Length)
        {
            res.Add(new List<int>(nums));
            return;
        }

        for (int i = index; i < nums.Length; i++)
        {
            Swap(nums, i, index);
            PermuteInternal(nums, index + 1, res);
            Swap(nums, i, index);
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];

        nums[i] = nums[j];
        nums[j] = temp;
    }
}
