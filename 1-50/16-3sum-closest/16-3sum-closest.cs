public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int result = int.MaxValue;
        int diff = result;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int j = i + 1;
            int k = nums.Length - 1;

            while (k > j)
            {
                int sum = nums[i] + nums[j] + nums[k];
                int diffTemp = target - sum;

                if (diffTemp == 0) return sum;

                diffTemp = Math.Abs(diffTemp);

                if (diff > diffTemp)
                {
                    diff = diffTemp;
                    result = sum;
                }

                if (sum > target) k--;
                else j++;
            }
        }

        return result;
    }
}
