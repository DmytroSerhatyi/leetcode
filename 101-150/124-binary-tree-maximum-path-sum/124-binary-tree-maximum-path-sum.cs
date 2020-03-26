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
    public int MaxPathSum(TreeNode root)
    {
        int max = int.MinValue;

        Helper(root, ref max);

        return max;
    }

    private int Helper(TreeNode node, ref int max)
    {
        if (node == null)
        {
            return 0;
        }

        int left = Math.Max(0, Helper(node.left, ref max));
        int right = Math.Max(0, Helper(node.right, ref max));
        int current = left + right + node.val;

        max = Math.Max(max, current);

        return node.val + Math.Max(left, right);
    }
}
