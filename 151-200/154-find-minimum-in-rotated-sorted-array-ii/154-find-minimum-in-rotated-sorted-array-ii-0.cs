public class Solution
{
    public int FindMin(int[] nums)
    {
        return FindMin(nums, 0, nums.Length - 1);
    }

    private int FindMin(int[] nums, int start, int end)
    {
        if (start == end)
        {
            return nums[start];
        }

        int mid = start + (end - start) / 2;

        if (nums[start] <= nums[mid] && nums[mid + 1] <= nums[end])
        {
            if (nums[mid] == nums[end])
            {
                return Math.Min(FindMin(nums, start, mid), FindMin(nums, mid + 1, end));
            }

            return nums[mid] < nums[end] ? FindMin(nums, start, mid) : FindMin(nums, mid + 1, end);
        }

        if (nums[start] > nums[mid])
        {
            return FindMin(nums, start, mid);
        }

        return FindMin(nums, mid + 1, end);
    }
}
