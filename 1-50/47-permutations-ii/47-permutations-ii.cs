public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();

        PermuteUniqueInternal(result, 0, nums);

        return result;
    }

    private bool ContainsDuplicates(int[] nums, int start, int end)
    {
        for (int i = start; i < end; i++) if (nums[i] == nums[end]) return false;

        return true;
    }

    private void PermuteUniqueInternal(IList<IList<int>> result, int index, int[] nums)
    {
        if (index == nums.Length)
        {
            result.Add(new List<int>(nums));

            return;
        }

        for (int i = index; i < nums.Length; i++)
        {
            if (ContainsDuplicates(nums, index, i))
            {
                Swap(nums, i, index);
                PermuteUniqueInternal(result, index + 1, nums);
                Swap(nums, i, index);
            }
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];

        nums[i] = nums[j];
        nums[j] = temp;
    }
}
