public class Trie
{
    private class Tree
    {
        public Tree[] links = new Tree[26];
        public bool isEnd;
    }

    private readonly Tree root;

    /** Initialize your data structure here. */
    public Trie()
    {
        root = new Tree();
    }

    /** Inserts a word into the trie. */
    public void Insert(string word)
    {
        Tree current = root;

        foreach (char c in word)
        {
            int i = c - 'a';

            if (current.links[i] == null)
            {
                current.links[i] = new Tree();
            }

            current = current.links[i];
        }

        current.isEnd = true;
    }

    /** Returns if the word is in the trie. */
    public bool Search(string word)
    {
        Tree t = SearchInternal(word);

        return t != null && t.isEnd;
    }

    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix)
    {
        return SearchInternal(prefix) != null;
    }

    private Tree SearchInternal(string w)
    {
        Tree current = root;

        foreach (char c in w)
        {
            if (current.links[c - 'a'] == null)
            {
                return null;
            }

            current = current.links[c - 'a'];
        }

        return current;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
