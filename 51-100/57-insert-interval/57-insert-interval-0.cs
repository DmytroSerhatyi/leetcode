public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        IList<int[]> result = new List<int[]>();

        for (int i = 0; i < intervals.Length; i++)
        {
            int[] interval = intervals[i];

            if (interval[0] > newInterval[1])
            {
                result.Add(newInterval);

                for (int j = i; j < intervals.Length; j++)
                {
                    result.Add(intervals[j]);
                }

                return result.ToArray();
            }
            else if (interval[1] >= newInterval[0])
            {
                newInterval = new[] { Math.Min(interval[0], newInterval[0]), Math.Max(interval[1], newInterval[1]) };
            }
            else
            {
                result.Add(interval);
            }
        }

        result.Add(newInterval);

        return result.ToArray();
    }
}
