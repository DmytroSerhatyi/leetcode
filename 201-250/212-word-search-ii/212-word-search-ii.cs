public class Solution
{
    private class Trie
    {
        public Trie[] next = new Trie[26];
        public string word;
    }

    public IList<string> FindWords(char[][] board, string[] words)
    {
        List<string> result = new List<string>();
        Trie root = BuildTrie(words);

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                DFS(board, i, j, root, result);
            }
        }

        return result;
    }

    private void DFS(char[][] board, int i, int j, Trie node, IList<string> result)
    {
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length)
        {
            return;
        }

        char c = board[i][j];

        if (c == '#' || node.next[c - 'a'] == null)
        {
            return;
        }

        node = node.next[c - 'a'];

        if (node.word != null)
        {
            result.Add(node.word);
            node.word = null;
        }

        board[i][j] = '#';
        DFS(board, i - 1, j, node, result);
        DFS(board, i, j - 1, node, result);
        DFS(board, i + 1, j, node, result);
        DFS(board, i, j + 1, node, result);
        board[i][j] = c;
    }

    private Trie BuildTrie(string[] words)
    {
        Trie root = new Trie();

        foreach (string word in words)
        {
            Trie node = root;

            foreach (char c in word)
            {
                int i = c - 'a';

                if (node.next[i] == null)
                {
                    node.next[i] = new Trie();
                }

                node = node.next[i];
            }

            node.word = word;
        }

        return root;
    }
}
