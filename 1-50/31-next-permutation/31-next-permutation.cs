public class Solution
{
    public void NextPermutation(int[] nums)
    {
        int i = nums.Length - 2;
        int j = nums.Length - 1;

        while (i >= 0 && nums[i] >= nums[i + 1]) i--;

        if (i >= 0)
        {
            while (nums[j] <= nums[i]) j--;

            Swap(nums, i, j);
        }

        i++;
        j = nums.Length - 1;

        while (i < j)
        {
            Swap(nums, i, j);
            i++;
            j--;
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}
