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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<int> result = new List<int>();

        stack.Push(root);

        while (stack.Any())
        {
            root = stack.Pop();

            while (root != null)
            {
                result.Add(root.val);

                if (root.right != null)
                {
                    stack.Push(root.right);
                }

                root = root.left;
            }
        }

        return result;
    }
}
