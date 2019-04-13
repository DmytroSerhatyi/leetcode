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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        if (root == null) return result;

        Stack<TreeNode> helper = new Stack<TreeNode>();
        Stack<TreeNode> reverseHelper = new Stack<TreeNode>();
        bool reverse = false;

        helper.Push(root);

        while (helper.Any())
        {
            IList<int> list = new List<int>();

            while (helper.Any())
            {
                TreeNode temp = helper.Pop();

                list.Add(temp.val);

                if (!reverse && temp.left != null) reverseHelper.Push(temp.left);

                if (temp.right != null) reverseHelper.Push(temp.right);

                if (reverse && temp.left != null) reverseHelper.Push(temp.left);
            }

            result.Add(list);

            Stack<TreeNode> tempHelper = helper;

            helper = reverseHelper;
            reverseHelper = tempHelper;
            reverse = !reverse;
        }

        return result;
    }
}
