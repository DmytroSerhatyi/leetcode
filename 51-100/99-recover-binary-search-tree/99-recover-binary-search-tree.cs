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
    private TreeNode prev;
    private TreeNode first;
    private TreeNode second;

    public void RecoverTree(TreeNode root)
    {
        CheckNodes(root);

        int temp = first.val;

        first.val = second.val;
        second.val = temp;
    }

    private void CheckNodes(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        CheckNodes(node.left);

        if (prev != null && prev.val > node.val && first == null)
        {
            first = prev;
        }

        if (prev != null && prev.val > node.val && first != null)
        {
            second = node;
        }

        prev = node;
        CheckNodes(node.right);
    }
}
