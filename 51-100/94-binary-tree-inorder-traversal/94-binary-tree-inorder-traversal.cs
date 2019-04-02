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
    public IList<int> InorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();

        while (root != null || stack.Any())
        {
            while (root != null)
            {
                stack.Push(root);
                root = root.left;
            }

            root = stack.Pop();
            result.Add(root.val);
            root = root.right;
        }

        return result;
    }
}
