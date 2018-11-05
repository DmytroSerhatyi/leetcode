public class Solution
{
    public int MaxArea(int[] height)
    {
        int max = 0;
        int i = 0;
        int j = height.Length - 1;

        while (i < j)
        {
            int temp = (height[i] > height[j] ? height[j] : height[i]) * (j - i);

            if (temp > max) max = temp;

            if (height[i] > height[j]) j--;
            else i++;
        }

        return max;
    }
}
