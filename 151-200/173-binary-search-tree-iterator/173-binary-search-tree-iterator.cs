/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BSTIterator
{
    private readonly Stack<TreeNode> stack = new Stack<TreeNode>();

    public BSTIterator(TreeNode root)
    {
        Traverse(root);
    }

    /** @return the next smallest number */
    public int Next()
    {
        TreeNode result = stack.Pop();

        if (result.right != null)
        {
            Traverse(result.right);
        }

        return result.val;
    }

    /** @return whether we have a next smallest number */
    public bool HasNext()
    {
        return stack.Any();
    }

    private void Traverse(TreeNode node)
    {
        while (node != null)
        {
            stack.Push(node);
            node = node.left;
        }
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
