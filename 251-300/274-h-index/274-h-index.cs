public class Solution
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations);

        int l = citations.Length;
        int i = 0;

        while (i < l && citations[l - i - 1] > i)
        {
            i++;
        }

        return i;
    }
}
