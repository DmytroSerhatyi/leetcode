public class Solution
{
    public bool CanJump(int[] nums)
    {
        int lastPosition = nums.Length - 1;

        for (int i = nums.Length - 1; i >= 0; i--) if (i + nums[i] >= lastPosition) lastPosition = i;

        return lastPosition == 0;
    }
}
