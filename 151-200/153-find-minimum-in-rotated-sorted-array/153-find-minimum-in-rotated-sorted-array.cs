public class Solution
{
    public int FindMin(int[] nums)
    {
        int start = 0;
        int end = nums.Length - 1;

        while (start < end)
        {
            if (nums[start] < nums[end])
            {
                return nums[start];
            }

            int mid = (end - start) / 2 + start;

            if (nums[start] <= nums[mid])
            {
                start = mid + 1;
            }
            else
            {
                end = mid;
            }
        }

        return nums[start];
    }
}
