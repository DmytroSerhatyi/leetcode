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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        if (root == null) return result;

        Queue<TreeNode> helper = new Queue<TreeNode>();

        helper.Enqueue(root);

        while (helper.Any())
        {
            IList<int> list = new List<int>();
            int counter = helper.Count;

            while (counter > 0)
            {
                TreeNode temp = helper.Dequeue();

                list.Add(temp.val);
                counter--;

                if (temp.left != null) helper.Enqueue(temp.left);

                if (temp.right != null) helper.Enqueue(temp.right);
            }

            result.Add(list);
        }

        return result;
    }
}
