/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
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
    public TreeNode SortedListToBST(ListNode head)
    {
        List<int> helper = new List<int>();

        while (head != null)
        {
            helper.Add(head.val);
            head = head.next;
        }

        return SortedListToBSTInternal(helper, 0, helper.Count - 1);
    }

    private TreeNode SortedListToBSTInternal(List<int> helper, int start, int end)
    {
        if (start > end) return null;

        int mid = (end - start) / 2 + start;
        TreeNode node = new TreeNode(helper[mid])
        {
            left = SortedListToBSTInternal(helper, start, mid - 1),
            right = SortedListToBSTInternal(helper, mid + 1, end)
        };

        return node;
    }
}
