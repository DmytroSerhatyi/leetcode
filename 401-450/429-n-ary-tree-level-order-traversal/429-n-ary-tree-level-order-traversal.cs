/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution
{
    public IList<IList<int>> LevelOrder(Node root)
    {
        var result = new List<IList<int>>();

        Travers(result, 0, root);

        return result;
    }

    public void Travers(IList<IList<int>> list, int level, Node node)
    {
        if (node == null) return;

        if (level >= list.Count) list.Add(new List<int>());

        list[level].Add(node.val);

        if (node.children == null || node.children.Count == 0) return;

        int nextLevel = ++level;

        for (var i = 0; i < node.children.Count; i++)
        {
            Travers(list, nextLevel, node.children[i]);
        }
    }
}
