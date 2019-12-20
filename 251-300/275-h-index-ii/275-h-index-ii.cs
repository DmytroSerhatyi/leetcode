public class Solution
{
    public int HIndex(int[] citations)
    {
        int start = 0;
        int end = citations.Length - 1;
        int l = citations.Length;
        int index = 0;

        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            int p = l - mid;

            if (citations[mid] < p)
            {
                start = mid + 1;
            }
            else
            {
                end = mid - 1;
                index = p;
            }
        }

        return index;
    }
}
