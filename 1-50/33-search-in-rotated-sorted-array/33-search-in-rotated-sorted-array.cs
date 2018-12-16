public class Solution
{
    public int Search(int[] nums, int target)
    {
        return Traverse(nums, target, 0, nums.Length - 1);
    }

    private int Traverse(int[] nums, int target, int begin, int end)
    {
        if (begin > end) return -1;

        int mid = begin + (end - begin) / 2;

        if (nums[mid] == target) return mid;

        if (nums[begin] <= nums[mid])
        {
            if (nums[begin] <= target && nums[mid] > target) return Traverse(nums, target, begin, mid - 1);

            return Traverse(nums, target, mid + 1, end);
        }

        if (nums[mid] < target && nums[end] >= target) return Traverse(nums, target, mid + 1, end);

        return Traverse(nums, target, begin, mid - 1);
    }
}
