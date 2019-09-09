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
    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> result = new List<int>();

        Traverse(root, result, 0);

        return result;
    }

    private void Traverse(TreeNode node, IList<int> result, int depth)
    {
        if (node == null)
        {
            return;
        }

        if (result.Count == depth)
        {
            result.Add(node.val);
        }

        Traverse(node.right, result, depth + 1);
        Traverse(node.left, result, depth + 1);
    }
}
