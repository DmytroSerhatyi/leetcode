/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node(){}
    public Node(int _val,IList<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
}
*/
public class Solution
{
    public Node CloneGraph(Node node)
    {
        if (node == null)
        {
            return null;
        }

        Dictionary<Node, Node> visited = new Dictionary<Node, Node>();

        return CloneGraphInternal(visited, node);
    }

    private Node CloneGraphInternal(Dictionary<Node, Node> visited, Node node)
    {
        if (visited.ContainsKey(node))
        {
            return visited[node];
        }

        Node clone = new Node
        {
            val = node.val
        };

        visited.Add(node, clone);

        if (node.neighbors != null)
        {
            clone.neighbors = new List<Node>();

            foreach (Node neighnor in node.neighbors)
            {
                clone.neighbors.Add(CloneGraphInternal(visited, neighnor));
            }
        }

        return clone;
    }
}
