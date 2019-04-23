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
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (postorder.Length == 0) return null;

        int index = postorder.Length - 1;
        TreeNode root = new TreeNode(postorder[index--]);
        Dictionary<int, int> indexes = new Dictionary<int, int>();

        for (int i = 0; i < inorder.Length; i++) indexes.Add(inorder[i], i);

        BuildTreeInternal(root, indexes, postorder, index, 0);

        return root;
    }

    private int BuildTreeInternal(TreeNode node, Dictionary<int, int> indexes, int[] postorder, int index, int left)
    {
        if (index < 0) return index;

        int valIndex = indexes[node.val];

        if (valIndex < indexes[postorder[index]])
        {
            node.right = new TreeNode(postorder[index]);
            index = BuildTreeInternal(node.right, indexes, postorder, index - 1, valIndex + 1);
        }

        if (index < 0) return index;

        int temp = indexes[postorder[index]];

        if (valIndex > temp && temp >= left)
        {
            node.left = new TreeNode(postorder[index]);
            index = BuildTreeInternal(node.left, indexes, postorder, index - 1, left);
        }

        return index;
    }
}
