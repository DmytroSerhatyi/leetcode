/**
 * Definition for an interval.
 * public class Interval {
 *     public int start;
 *     public int end;
 *     public Interval() { start = 0; end = 0; }
 *     public Interval(int s, int e) { start = s; end = e; }
 * }
 */
public class Solution
{
    public IList<Interval> Merge(IList<Interval> intervals)
    {
        IList<Interval> result = new List<Interval>();

        intervals = intervals.OrderBy(i => i.start).ToList();

        foreach (Interval i in intervals)
        {
            if (result.Count == 0 || result.Last().end < i.start) result.Add(i);
            else if (result.Last().end < i.end) result.Last().end = i.end;
        }

        return result;
    }
}
