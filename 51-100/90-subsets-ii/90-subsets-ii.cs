public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);

        IList<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i <= nums.Length; i++) SubsetsWithDupInternal(nums, result, new int[i], 0, 0);

        return result;
    }

    private void SubsetsWithDupInternal(int[] nums, IList<IList<int>> result, int[] store, int index, int start)
    {
        if (index == store.Length)
        {
            result.Add(new List<int>(store));

            return;
        }

        for (int i = start; i < nums.Length - store.Length + 1 + index; i++)
        {
            if (i != start && nums[i] == nums[i - 1]) continue;

            store[index] = nums[i];
            SubsetsWithDupInternal(nums, result, store, index + 1, i + 1);
        }
    }
}
