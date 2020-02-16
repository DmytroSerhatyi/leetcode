public class Solution
{
    public int TotalNQueens(int n)
    {
        return TotalNQueens(0, n, new int[n]);
    }

    private int TotalNQueens(int row, int size, int[] rows)
    {
        if (size == row)
        {
            return 1;
        }

        int total = 0;

        for (int col = 0; col < size; col++)
        {
            if (IsValid(row, col, rows))
            {
                rows[row] = col;
                total += TotalNQueens(row + 1, size, rows);
            }
        }

        return total;
    }

    private bool IsValid(int row, int col, int[] rows)
    {
        for (int r = 0; r < row; r++)
        {
            int c = rows[r];

            if (col == c || Math.Abs(r - row) == Math.Abs(c - col))
            {
                return false;
            }
        }

        return true;
    }
}
