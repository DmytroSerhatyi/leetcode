public class Solution
{
    public int[] SingleNumber(int[] nums)
    {
        int xor = 0;

        foreach (int n in nums)
        {
            xor ^= n;
        }

        int bit = ~(xor - 1) & xor;
        int n1 = 0;
        int n2 = 0;

        foreach (int n in nums)
        {
            if ((n & bit) == 0)
            {
                n1 ^= n;
            }
            else
            {
                n2 ^= n;
            }
        }

        return new[] { n1, n2 };
    }
}
