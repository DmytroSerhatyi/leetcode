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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> result = new List<int>();

        if (root == null)
        {
            return result;
        }

        Stack<TreeNode> stack = new Stack<TreeNode>();

        stack.Push(root);

        while (stack.Any())
        {
            TreeNode node = stack.Pop();

            result.Add(node.val);

            if (node.left != null)
            {
                stack.Push(node.left);
            }

            if (node.right != null)
            {
                stack.Push(node.right);
            }
        }

        return result.Reverse().ToList();
    }
}
