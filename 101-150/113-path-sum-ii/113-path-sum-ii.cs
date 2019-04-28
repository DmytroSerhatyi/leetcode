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
    public IList<IList<int>> PathSum(TreeNode root, int sum)
    {
        IList<IList<int>> result = new List<IList<int>>();

        PathSumInternal(result, new List<int>(), root, sum);

        return result;
    }

    private void PathSumInternal(IList<IList<int>> result, IList<int> helper, TreeNode node, int sum)
    {
        if (node == null) return;

        sum -= node.val;
        helper.Add(node.val);

        if (sum == 0 && node.left == null && node.right == null) result.Add(new List<int>(helper));
        else
        {
            PathSumInternal(result, helper, node.left, sum);
            PathSumInternal(result, helper, node.right, sum);
        }

        helper.RemoveAt(helper.Count - 1);
    }
}
