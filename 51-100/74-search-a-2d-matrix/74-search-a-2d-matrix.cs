public class Solution
{
    public bool SearchMatrix(int[,] matrix, int target)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        if (m == 0 || n == 0) return false;

        int begin = 0;
        int end = m * n;

        while (begin < end)
        {
            int mid = (end + begin) / 2;
            int midRow = mid / n;
            int midCol = mid % n;
            int val = matrix[midRow, midCol];

            if (val == target) return true;

            if (val < target) begin = mid + 1;
            else end = mid;
        }

        return false;
    }
}
