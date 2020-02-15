public class Solution
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        IList<IList<string>> result = new List<IList<string>>();
        char[][] board = new char[n][];

        for (int i = 0; i < n; i++)
        {
            board[i] = new char[n];

            for (int j = 0; j < n; j++)
            {
                board[i][j] = '.';
            }
        }

        SetQueen(board, 0, 0, 0, 0, result);

        return result;
    }

    private void SetQueen(char[][] board, int row, int col, int diag, int back, IList<IList<string>> result)
    {
        int size = board.Length;

        if (row == size)
        {
            IList<string> res = new List<string>();

            foreach (char[] chars in board)
            {
                res.Add(new string(chars));
            }

            result.Add(res);

            return;
        }

        int candidate = col | diag | back;

        for (int shift = 0, mask = 1; shift < size; shift++, mask <<= 1)
        {
            if ((candidate & mask) > 0)
            {
                continue;
            }

            board[row][shift] = 'Q';
            SetQueen(board, row + 1, col | mask, (diag | mask) << 1, (back | mask) >> 1, result);
            board[row][shift] = '.';
        }
    }
}
