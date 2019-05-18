public class Solution
{
    public void Solve(char[][] board)
    {
        int height = board.Length;

        if (height == 0)
        {
            return;
        }

        int width = board[0].Length;
        int i;

        for (i = 0; i < width; i++)
        {
            MarkCell(board, 0, i);
            MarkCell(board, height - 1, width - 1 - i);
        }

        for (i = 1; i < height - 1; i++)
        {
            MarkCell(board, i, width - 1);
            MarkCell(board, height - 1 - i, 0);
        }

        for (i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                if (board[i][j] == 'O')
                {
                    board[i][j] = 'X';
                }
                else if (board[i][j] == 'Y')
                {
                    board[i][j] = 'O';
                }
            }
        }
    }

    private void MarkCell(char[][] board, int h, int w)
    {
        if (h < 0 || h >= board.Length || w < 0 || w >= board[0].Length || board[h][w] == 'X' || board[h][w] == 'Y')
        {
            return;
        }

        board[h][w] = 'Y';

        MarkCell(board, h - 1, w);
        MarkCell(board, h + 1, w);
        MarkCell(board, h, w - 1);
        MarkCell(board, h, w + 1);
    }
}
