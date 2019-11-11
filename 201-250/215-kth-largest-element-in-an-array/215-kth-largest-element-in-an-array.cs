public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        List<int> n = new List<int>(nums);

        n.Sort((a, b) => a - b);

        return n[n.Count - k];
    }
}
