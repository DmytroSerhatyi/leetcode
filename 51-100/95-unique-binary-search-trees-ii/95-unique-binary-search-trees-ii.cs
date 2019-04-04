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
    public IList<TreeNode> GenerateTrees(int n)
    {
        if (n == 0) return new List<TreeNode>();

        return GenerateTreesInternal(1, n);
    }

    private IList<TreeNode> GenerateTreesInternal(int start, int end)
    {
        IList<TreeNode> list = new List<TreeNode>();

        if (start > end)
        {
            list.Add(null);

            return list;
        }

        if (start == end)
        {
            list.Add(new TreeNode(start));

            return list;
        }

        for (int i = start; i <= end; i++)
        {
            IList<TreeNode> leftNodes = GenerateTreesInternal(start, i - 1);
            IList<TreeNode> rightNodes = GenerateTreesInternal(i + 1, end);

            foreach (TreeNode left in leftNodes)
            {
                foreach (TreeNode right in rightNodes)
                {
                    TreeNode root = new TreeNode(i);

                    root.left = left;
                    root.right = right;
                    list.Add(root);
                }
            }
        }

        return list;
    }
}
