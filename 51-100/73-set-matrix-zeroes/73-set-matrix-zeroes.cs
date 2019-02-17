public class Solution
{
    public void SetZeroes(int[,] matrix)
    {
        bool firstCol = false;
        bool firstRow = false;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, 0] == 0)
            {
                firstCol = true;
                break;
            }
        }

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix[0, i] == 0)
            {
                firstRow = true;
                break;
            }
        }

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    matrix[i, 0] = 0;
                    matrix[0, j] = 0;
                }
            }
        }

        for (int i = 1; i < matrix.GetLength(0); i++) if (matrix[i, 0] == 0) for (int j = 1; j < matrix.GetLength(1); j++) matrix[i, j] = 0;

        for (int i = 1; i < matrix.GetLength(1); i++) if (matrix[0, i] == 0) for (int j = 1; j < matrix.GetLength(0); j++) matrix[j, i] = 0;

        if (firstCol) for (int i = 0; i < matrix.GetLength(0); i++) matrix[i, 0] = 0;

        if (firstRow) for (int i = 0; i < matrix.GetLength(1); i++) matrix[0, i] = 0;
    }
}
