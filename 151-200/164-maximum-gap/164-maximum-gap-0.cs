public class Solution
{
    public int MaximumGap(int[] nums)
    {
        Array.Sort(nums);

        int result = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            int diff = nums[i] - nums[i - 1];

            if (diff > result)
            {
                result = diff;
            }
        }

        return result;
    }
}
