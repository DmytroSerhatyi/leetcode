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
    public int CountNodes(TreeNode root)
    {
        int depth = 0;
        TreeNode current = root;

        while (current != null)
        {
            depth++;
            current = current.left;
        }

        int maxNodes = (int)Math.Pow(2, depth - 1);
        int left = 1;
        int right = maxNodes;

        while (left < right)
        {
            int mid = left + (right - left + 1) / 2;
            int m = mid;
            int nodes = maxNodes;
            int tempDepth = 0;

            current = root;

            while (current != null)
            {
                tempDepth++;
                nodes /= 2;

                if (m <= nodes)
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                    m -= nodes;
                }
            }

            if (tempDepth == depth)
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return maxNodes - 1 + left;
    }
}
