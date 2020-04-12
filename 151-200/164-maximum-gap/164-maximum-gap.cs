public class Solution
{
    public int MaximumGap(int[] nums)
    {
        if (nums.Length < 2)
        {
            return 0;
        }

        int min = int.MaxValue;
        int max = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
        }

        int bucketSize = Math.Max(1, (max - min) / (nums.Length - 1));
        int bucketCount = (max - min) / bucketSize + 1;
        int[] minArr = new int[bucketCount];
        int[] maxArr = new int[bucketCount];
        bool[] usedArr = new bool[bucketCount];

        for (int i = 0; i < nums.Length; i++)
        {
            int bucketIndex = (nums[i] - min) / bucketSize;

            minArr[bucketIndex] = usedArr[bucketIndex] ? Math.Min(minArr[bucketIndex], nums[i]) : nums[i];
            maxArr[bucketIndex] = usedArr[bucketIndex] ? Math.Max(maxArr[bucketIndex], nums[i]) : nums[i];
            usedArr[bucketIndex] = true;
        }

        int result = 0;
        int tempResult = maxArr[0];

        for (int i = 1; i < bucketCount; i++)
        {
            if (usedArr[i])
            {
                result = Math.Max(result, minArr[i] - tempResult);
                tempResult = maxArr[i];
            }
        }

        return result;
    }
}
