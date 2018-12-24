public class Solution
{
    public bool IsValidSudoku(char[,] board)
    {
        int s = 9;
        bool[,] rows = new bool[s, s];
        bool[,] columns = new bool[s, s];
        bool[,] squares = new bool[s, s];

        for (int i = 0; i < s; i++)
        {
            for (int j = 0; j < s; j++)
            {
                if (board[i, j] == '.') continue;

                int charIndex = board[i, j] - '1';
                int squareIndex = (i / 3) * 3 + j / 3;

                if (rows[i, charIndex] || columns[j, charIndex] || squares[squareIndex, charIndex]) return false;

                rows[i, charIndex] = columns[j, charIndex] = squares[squareIndex, charIndex] = true;
            }
        }

        return true;
    }
}
