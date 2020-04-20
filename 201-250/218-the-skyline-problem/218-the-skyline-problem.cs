public class Solution
{
    public IList<IList<int>> GetSkyline(int[][] buildings)
    {
        return Merge(buildings, 0, buildings.Length - 1).ToList();
    }

    private Queue<IList<int>> Merge(int[][] buildings, int lo, int hi)
    {
        Queue<IList<int>> result = new Queue<IList<int>>();

        if (lo > hi)
        {
            return result;
        }
        else if (lo == hi)
        {
            result.Enqueue(new[] { buildings[lo][0], buildings[lo][2] });
            result.Enqueue(new[] { buildings[lo][1], 0 });

            return result;
        }

        int mid = lo + (hi - lo) / 2;
        Queue<IList<int>> left = Merge(buildings, lo, mid);
        Queue<IList<int>> right = Merge(buildings, mid + 1, hi);
        int leftY = 0;
        int rightY = 0;
        IList<int> last = null;

        while (left.Count != 0 || right.Count != 0)
        {
            long leftX = left.Count == 0 ? long.MaxValue : left.Peek()[0];
            long rightX = right.Count == 0 ? long.MaxValue : right.Peek()[0];
            int x;

            if (leftX < rightX)
            {
                IList<int> temp = left.Dequeue();
                x = temp[0];
                leftY = temp[1];
            }
            else if (rightX < leftX)
            {
                IList<int> temp = right.Dequeue();
                x = temp[0];
                rightY = temp[1];
            }
            else
            {
                IList<int> tempL = left.Dequeue();
                IList<int> tempR = right.Dequeue();

                x = tempL[0];
                leftY = tempL[1];
                rightY = tempR[1];
            }

            int h = Math.Max(leftY, rightY);

            if (last == null || h != last[1])
            {
                last = new List<int> { x, h };
                result.Enqueue(last);
            }
        }

        return result;
    }
}
