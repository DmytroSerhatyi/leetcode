/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(){}
    public Node(int _val,Node _next,Node _random) {
        val = _val;
        next = _next;
        random = _random;
}
*/
public class Solution
{
    public Node CopyRandomList(Node head)
    {
        return CopyRandomListInternal(new Dictionary<Node, Node>(), head);
    }

    private Node CopyRandomListInternal(Dictionary<Node, Node> store, Node node)
    {
        if (node == null)
        {
            return null;
        }

        bool firstTry = !store.ContainsKey(node);

        if (firstTry)
        {
            store.Add(node, new Node { val = node.val });
        }

        Node clone = store[node];

        if (firstTry)
        {
            clone.next = CopyRandomListInternal(store, node.next);
            clone.random = CopyRandomListInternal(store, node.random);
        }

        return clone;
    }
}
