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
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode first = head;
        ListNode second = head;

        for (int i = 0; i <= n; i++)
        {
            if (first == null) return head.next;
            else first = first.next;
        }

        while (first != null)
        {
            first = first.next;
            second = second.next;
        }

        second.next = second.next.next;

        return head;
    }
}
