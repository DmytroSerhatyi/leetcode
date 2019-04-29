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
    public void Flatten(TreeNode root)
    {
        if (root != null) FlattenInternal(root);
    }

    private TreeNode FlattenInternal(TreeNode node)
    {
        if (node.left == null && node.right == null) return node;

        if (node.left != null)
        {
            TreeNode right = node.right;

            node.right = node.left;
            node.left = null;

            TreeNode tail = FlattenInternal(node.right);

            if (right != null)
            {
                tail.right = right;

                return FlattenInternal(right);
            }

            return tail;
        }

        return FlattenInternal(node.right);
    }
}
