public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int result = nums[0];
        int max = result;
        int min = result;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                int temp = max;

                max = min;
                min = temp;
            }

            max = Math.Max(max * nums[i], nums[i]);
            min = Math.Min(min * nums[i], nums[i]);
            result = Math.Max(max, result);
        }

        return result;
    }
}
