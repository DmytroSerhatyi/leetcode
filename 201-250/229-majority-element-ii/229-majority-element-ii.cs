public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        IList<int> result = new List<int>();
        int third = nums.Length / 3;
        int first = 0;
        int second = 1;
        int firstCount = 0;
        int secondCount = 0;

        foreach (int num in nums)
        {
            if (num == first)
            {
                firstCount++;
            }
            else if (num == second)
            {
                secondCount++;
            }
            else if (firstCount == 0)
            {
                firstCount++;
                first = num;
            }
            else if (secondCount == 0)
            {
                secondCount++;
                second = num;
            }
            else
            {
                firstCount--;
                secondCount--;
            }
        }

        firstCount = 0;
        secondCount = 0;

        foreach (int num in nums)
        {
            if (num == first)
            {
                firstCount++;
            }
            else if (num == second)
            {
                secondCount++;
            }
        }

        if (firstCount > third)
        {
            result.Add(first);
        }

        if (secondCount > third)
        {
            result.Add(second);
        }

        return result;
    }
}
