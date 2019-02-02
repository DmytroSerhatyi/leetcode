/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null) return head;

        int length = 1;
        ListNode node = head;

        while (node.next != null)
        {
            node = node.next;
            length++;
        }

        k %= length;

        if (k == 0) return head;

        int target = length - k;
        int i = 0;
        ListNode lastNode = node;

        node = head;
        lastNode.next = head;

        while (i < target)
        {
            node = node.next;
            lastNode = lastNode.next;
            i++;
        }

        lastNode.next = null;

        return node;
    }
}
