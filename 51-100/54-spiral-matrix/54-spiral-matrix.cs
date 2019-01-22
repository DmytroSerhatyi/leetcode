public class Solution
{
    public IList<int> SpiralOrder(int[,] matrix)
    {
        IList<int> result = new List<int>();
        int i = 0;
        int j = 0;
        int width = matrix.GetLength(1) - 1;
        int height = matrix.GetLength(0) - 1;

        while (i <= width && j <= height)
        {
            for (int iw = i; iw <= width; iw++) result.Add(matrix[j, iw]);

            for (int jh = j + 1; jh <= height; jh++) result.Add(matrix[jh, width]);

            if (i < width && j < height)
            {
                for (int iw = width - 1; iw > i; iw--) result.Add(matrix[height, iw]);

                for (int jh = height; jh > j; jh--) result.Add(matrix[jh, i]);
            }

            i++;
            j++;
            width--;
            height--;
        }

        return result;
    }
}
