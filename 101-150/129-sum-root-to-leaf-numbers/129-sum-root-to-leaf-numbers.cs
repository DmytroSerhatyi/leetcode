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
    public int SumNumbers(TreeNode root)
    {
        IList<int> storage = new List<int>();

        SumNumbersInternal(storage, 0, root);

        int result = 0;

        foreach (int num in storage) result += num;

        return result;
    }

    private void SumNumbersInternal(IList<int> storage, int sum, TreeNode node)
    {
        if (node == null) return;

        sum = sum * 10 + node.val;

        if (node.left == null && node.right == null) storage.Add(sum);
        else
        {
            SumNumbersInternal(storage, sum, node.left);
            SumNumbersInternal(storage, sum, node.right);
        }
    }
}
