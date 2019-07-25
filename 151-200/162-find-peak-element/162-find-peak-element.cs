public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }

        int start = 0;
        int end = nums.Length - 1;

        while (end > start)
        {
            int mid = (end - start) / 2 + start;

            if (nums[mid] < nums[mid + 1])
            {
                start = mid + 1;
            }
            else
            {
                end = mid;
            }
        }

        return start;
    }
}
