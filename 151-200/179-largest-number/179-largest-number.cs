public class Solution
{
    public string LargestNumber(int[] nums)
    {
        Array.Sort(nums, (a, b) =>
        {
            string aS = a.ToString();
            string bS = b.ToString();
            string af = aS + bS;
            string bf = bS + aS;

            for (int i = 0; i < af.Length; i++)
            {
                if (af[i] == bf[i])
                {
                    continue;
                }

                return bf[i] - af[i];
            }

            return 0;
        });

        return nums[0] == 0 ? "0" : string.Join(string.Empty, nums);
    }
}
