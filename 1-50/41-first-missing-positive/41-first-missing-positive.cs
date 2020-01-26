public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] <= 0)
            {
                nums[i] = nums.Length + 1;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (Math.Abs(nums[i]) <= nums.Length)
            {
                int n = nums[Math.Abs(nums[i]) - 1];

                if (n > 0)
                {
                    nums[Math.Abs(nums[i]) - 1] = -n;
                }
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                return i + 1;
            }
        }

        return nums.Length + 1;
    }
}
