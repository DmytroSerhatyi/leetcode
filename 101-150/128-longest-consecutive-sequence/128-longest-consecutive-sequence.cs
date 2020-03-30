public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        ISet<int> set = new HashSet<int>(nums);
        int result = 1;
        int tempResult;
        int currentNum;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                currentNum = num;
                tempResult = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    tempResult += 1;
                }

                if (tempResult > result)
                {
                    result = tempResult;
                }
            }
        }

        return result;
    }
}
