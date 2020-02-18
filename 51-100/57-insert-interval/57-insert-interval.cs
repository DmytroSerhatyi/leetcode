public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        IList<int[]> result = new List<int[]>();
        bool mergeStarted = false;
        bool searchCompleted = false;
        int start = newInterval[0];
        int end = newInterval[1];
        int[] mergedInterval = new int[2];

        for (int i = 0; i < intervals.Length; i++)
        {
            if (searchCompleted)
            {
                result.Add(intervals[i]);

                continue;
            }

            int[] interval = intervals[i];

            if (mergeStarted)
            {
                if (end >= interval[1])
                {
                    continue;
                }
                else if (end < interval[0])
                {
                    mergedInterval[1] = end;
                    result.Add(mergedInterval);
                    result.Add(interval);
                    searchCompleted = true;
                }
                else
                {
                    mergedInterval[1] = interval[1];
                    result.Add(mergedInterval);
                    searchCompleted = true;
                }
            }
            else
            {
                if (start < interval[0])
                {
                    mergedInterval[0] = start;
                    mergeStarted = true;
                    i--;
                }
                else if (start >= interval[0] && start <= interval[1])
                {
                    mergedInterval[0] = interval[0];
                    mergeStarted = true;
                    i--;
                }
                else
                {
                    result.Add(interval);
                }
            }
        }

        if (!searchCompleted)
        {
            if (mergeStarted)
            {
                mergedInterval[1] = end;
                result.Add(mergedInterval);
            }
            else
            {
                result.Add(newInterval);
            }
        }

        return result.ToArray();
    }
}
