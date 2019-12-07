public class Solution
{
    public int RangeBitwiseAnd(int m, int n)
    {
        int i = 0;

        while (m != n)
        {
            i++;
            m >>= 1;
            n >>= 1;
        }

        return m << i;
    }
}