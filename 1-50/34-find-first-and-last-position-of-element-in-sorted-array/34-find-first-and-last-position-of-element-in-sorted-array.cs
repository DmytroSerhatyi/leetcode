public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] result = { -1, -1 };
        int start = FindIndex(nums, target, true);

        if (start == nums.Length || nums[start] != target) return result;

        result[0] = start;
        result[1] = FindIndex(nums, target, false) - 1;

        return result;
    }

    public int FindIndex(int[] nums, int target, bool first)
    {
        int left = 0;
        int right = nums.Length;

        while (left < right)
        {
            int mid = (right - left) / 2 + left;

            if (nums[mid] > target || (first && target == nums[mid])) right = mid;
            else left = mid + 1;
        }

        return left;
    }
}
