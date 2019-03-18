public class Solution
{
    public bool Search(int[] nums, int target)
    {
        if (nums.Length == 0) return false;

        int start = 0;
        int end = nums.Length - 1;

        while (start <= end)
        {
            int mid = (end - start) / 2 + start;

            if (nums[mid] == target) return true;

            if (nums[start] < nums[mid])
            {
                if (nums[start] <= target && nums[mid] > target) end = mid - 1;
                else start = mid + 1;
            }
            else if (nums[start] > nums[mid])
            {
                if (nums[mid] < target && nums[end] >= target) start = mid + 1;
                else end = mid - 1;
            }
            else start++;
        }

        return false;
    }
}
