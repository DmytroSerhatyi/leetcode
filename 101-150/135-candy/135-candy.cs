public class Solution
{
    public int Candy(int[] ratings)
    {
        if (ratings.Length == 0)
        {
            return 0;
        }

        int result = 1;
        int up = 0;
        int down = 0;
        int peak = 0;

        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i - 1] < ratings[i])
            {
                up++;
                peak = up;
                down = 0;
                result += 1 + up;
            }
            else if (ratings[i - 1] == ratings[i])
            {
                peak = up = down = 0;
                result += 1;
            }
            else
            {
                up = 0;
                down++;
                result += 1 + down + (peak >= down ? -1 : 0);
            }
        }

        return result;
    }
}
