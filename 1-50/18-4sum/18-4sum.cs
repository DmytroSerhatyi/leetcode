public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            for (int j = nums.Length - 1; j > i; j--)
            {
                if (j < nums.Length - 1 && nums[j] == nums[j + 1]) continue;

                int k = i + 1;
                int lm = j - 1;

                while (k < lm)
                {
                    if (nums[i] + nums[j] + nums[k] + nums[lm] == target)
                    {
                        result.Add(new int[] { nums[i], nums[j], nums[k], nums[lm] });
                        k++;
                        lm--;

                        while (k < lm && nums[k] == nums[k - 1]) k++;
                        while (k < lm && nums[lm] == nums[lm + 1]) lm--;
                    }
                    else if (nums[i] + nums[j] + nums[k] + nums[lm] < target) k++;
                    else lm--;
                }
            }
        }

        return result;
    }
}
