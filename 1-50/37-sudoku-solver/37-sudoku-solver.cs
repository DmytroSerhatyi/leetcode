public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        Solve(board, 0, 0);
    }

    private bool Solve(char[][] board, int row, int col)
    {
        if (col == 9)
        {
            col = 0;
            row++;
        }

        if (row == 9)
        {
            return true;
        }

        if (board[row][col] != '.')
        {
            return Solve(board, row, col + 1);
        }

        for (int i = 1; i < 10; i++)
        {
            char c = (char)(i + '0');

            if (IsValidMove(board, row, col, c))
            {
                board[row][col] = c;

                if (Solve(board, row, col + 1))
                {
                    return true;
                }
            }

            board[row][col] = '.';
        }

        return false;
    }

    private bool IsValidMove(char[][] board, int row, int col, char c)
    {
        int blockRow = 3 * (row / 3);
        int blockCol = 3 * (col / 3);

        for (int i = 0; i < 9; i++)
        {
            if (board[i][col] == c || board[row][i] == c || board[blockRow + i / 3][blockCol + i % 3] == c)
            {
                return false;
            }
        }

        return true;
    }
}
