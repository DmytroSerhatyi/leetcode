public class Solution
{
    public bool SearchMatrix(int[,] matrix, int target)
    {
        int columns = matrix.GetLength(1);
        int i = matrix.GetLength(0) - 1;
        int j = 0;

        while (i >= 0 && j < columns)
        {
            int t = matrix[i, j];

            if (t == target)
            {
                return true;
            }

            if (t > target)
            {
                i--;
            }
            else
            {
                j++;
            }
        }

        return false;
    }
}
