public class Solution
{
    public bool Exist(char[,] board, string word)
    {
        if (word.Length == 0) return true;

        bool[,] store = new bool[board.GetLength(0), board.GetLength(1)];

        for (int i = 0; i < board.GetLength(0); i++) for (int j = 0; j < board.GetLength(1); j++) if (Search(board, word, i, j, 0, store)) return true;

        return false;
    }

    private bool Search(char[,] board, string word, int i, int j, int index, bool[,] store)
    {
        if (board[i, j] != word[index] || store[i, j]) return false;

        if (index == word.Length - 1) return true;

        store[i, j] = true;

        if (i > 0 && !store[i - 1, j]) if (Search(board, word, i - 1, j, index + 1, store)) return true;

        if (j < board.GetLength(1) - 1 && !store[i, j + 1]) if (Search(board, word, i, j + 1, index + 1, store)) return true;

        if (i < board.GetLength(0) - 1 && !store[i + 1, j]) if (Search(board, word, i + 1, j, index + 1, store)) return true;

        if (j > 0 && !store[i, j - 1]) if (Search(board, word, i, j - 1, index + 1, store)) return true;

        store[i, j] = false;

        return false;
    }
}
