public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        IList<string> result = new List<string>();

        if (nums.Length == 0)
        {
            return result;
        }

        int start = nums[0];
        int end = start;

        void Add()
        {
            result.Add(start == end ? start.ToString() : $"{start}->{end}");
        }

        for (int i = 1; i < nums.Length; i++)
        {
            if (end + 1 == nums[i])
            {
                end = nums[i];
            }
            else
            {
                Add();
                start = end = nums[i];
            }
        }

        Add();

        return result;
    }
}
