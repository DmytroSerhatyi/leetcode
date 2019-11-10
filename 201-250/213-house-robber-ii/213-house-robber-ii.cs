public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            return 0;
        }

        if (nums.Length == 1)
        {
            return nums[0];
        }

        return Math.Max(Rob(nums, 0, nums.Length - 1), Rob(nums, 1, nums.Length));
    }

    private int Rob(int[] nums, int start, int end)
    {
        int current = nums[start];
        int prev = 0;

        for (int i = start + 1; i < end; i++)
        {
            int temp = current;

            current = Math.Max(current, nums[i] + prev);
            prev = temp;
        }

        return current;
    }
}
