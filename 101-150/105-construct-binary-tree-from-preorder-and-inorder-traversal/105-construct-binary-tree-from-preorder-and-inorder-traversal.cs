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
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        if (preorder.Length == 0) return null;

        TreeNode root = new TreeNode(preorder[0]);
        Dictionary<int, int> indexes = new Dictionary<int, int>();

        for (int i = 0; i < inorder.Length; i++) indexes.Add(inorder[i], i);

        BuildTreeInternal(root, preorder, indexes, 1, inorder.Length - 1);

        return root;
    }

    private int BuildTreeInternal(TreeNode node, int[] preorder, Dictionary<int, int> indexes, int index, int right)
    {
        if (index >= preorder.Length) return index;

        int valIndex = indexes[node.val];

        if (valIndex > indexes[preorder[index]])
        {
            node.left = new TreeNode(preorder[index]);
            index = BuildTreeInternal(node.left, preorder, indexes, index + 1, valIndex - 1);
        }

        if (index >= preorder.Length) return index;

        int temp = indexes[preorder[index]];

        if (valIndex < temp && temp <= right)
        {
            node.right = new TreeNode(preorder[index]);
            index = BuildTreeInternal(node.right, preorder, indexes, index + 1, right);
        }

        return index;
    }
}
