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
    public bool IsValidBST(TreeNode root)
    {
        return IsValid(root, long.MinValue, long.MaxValue);
    }

    private bool IsValid(TreeNode node, long min, long max)
    {
        if (node == null) return true;

        if (node.val <= min || node.val >= max) return false;

        return IsValid(node.left, min, node.val) && IsValid(node.right, node.val, max);
    }
}
