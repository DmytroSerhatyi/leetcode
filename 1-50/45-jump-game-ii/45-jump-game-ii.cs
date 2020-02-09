public class Solution
{
    public int Jump(int[] nums)
    {
        int jumps = 0;
        int furthest = -1;
        int target = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            furthest = Math.Max(nums[i] + i, furthest);

            if (i == target)
            {
                jumps++;
                target = furthest;
            }
        }

        return jumps;
    }
}
