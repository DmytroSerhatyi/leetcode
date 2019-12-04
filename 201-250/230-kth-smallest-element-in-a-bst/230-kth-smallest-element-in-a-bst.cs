/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public int KthSmallest(TreeNode root, int k)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        TraverseLeft(root, stack);
        root = stack.Pop();

        while (root != null && k > 1)
        {
            if (root.right != null)
            {
                root = root.right;
                TraverseLeft(root, stack);
            }

            root = stack.Pop();
            k--;
        }

        return root.val;
    }

    private void TraverseLeft(TreeNode node, Stack<TreeNode> stack)
    {
        while (node != null)
        {
            stack.Push(node);
            node = node.left;
        }
    }
}
