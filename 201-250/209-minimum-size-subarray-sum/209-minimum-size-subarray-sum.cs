public class Solution
{
    public int MinSubArrayLen(int s, int[] nums)
    {
        int sum = 0;
        int minLength = 0;
        int start = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            while (sum >= s)
            {
                if (minLength > i - start + 1 || minLength == 0)
                {
                    minLength = i - start + 1;
                }

                sum -= nums[start++];
            }
        }

        return minLength;
    }
}
