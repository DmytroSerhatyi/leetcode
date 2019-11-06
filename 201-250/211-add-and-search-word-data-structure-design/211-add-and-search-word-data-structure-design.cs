public class WordDictionary
{
    private class Trie
    {
        public Trie[] children = new Trie[26];
        public bool isEnd;
    }

    private readonly Trie root;

    /** Initialize your data structure here. */
    public WordDictionary()
    {
        root = new Trie();
    }

    /** Adds a word into the data structure. */
    public void AddWord(string word)
    {
        Trie current = root;

        for (int i = 0; i < word.Length; i++)
        {
            int c = word[i] - 'a';

            if (current.children[c] == null)
            {
                current.children[c] = new Trie();
            }

            current = current.children[c];
        }

        current.isEnd = true;
    }

    /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
    public bool Search(string word)
    {
        return SearchInternal(word, 0, root);
    }

    private bool SearchInternal(string word, int i, Trie current)
    {
        if (current == null)
        {
            return false;
        }

        if (word.Length == i)
        {
            return current.isEnd;
        }

        if (word[i] == '.')
        {
            foreach (Trie c in current.children)
            {
                if (SearchInternal(word, i + 1, c))
                {
                    return true;
                }
            }

            return false;
        }

        if (current.children[word[i] - 'a'] == null)
        {
            return false;
        }

        return SearchInternal(word, i + 1, current.children[word[i] - 'a']);
    }
}

/**
 * Your WordDictionary object will be instantiated and called as such:
 * WordDictionary obj = new WordDictionary();
 * obj.AddWord(word);
 * bool param_2 = obj.Search(word);
 */
