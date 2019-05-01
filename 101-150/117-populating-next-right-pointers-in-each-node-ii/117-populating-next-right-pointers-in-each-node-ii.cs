/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node(){}
    public Node(int _val,Node _left,Node _right,Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
}
*/
public class Solution
{
    public Node Connect(Node root)
    {
        Node dummy = new Node();
        Node prev = dummy;
        Node node = root;

        while (node != null)
        {
            while (node != null)
            {
                if (node.left != null) prev = prev.next = node.left;

                if (node.right != null) prev = prev.next = node.right;

                node = node.next;
            }

            node = dummy.next;
            dummy.next = null;
            prev = dummy;
        }

        return root;
    }
}
