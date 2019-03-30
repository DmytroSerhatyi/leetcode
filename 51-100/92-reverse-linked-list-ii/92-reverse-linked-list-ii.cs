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
    public ListNode ReverseBetween(ListNode head, int m, int n)
    {
        ListNode prev = null;
        ListNode current = head;
        int counter = 1;

        while (counter < m)
        {
            prev = current;
            current = current.next;
            counter++;
        }

        ListNode connectTo = prev;
        ListNode end = current;
        ListNode next = null;

        while (counter <= n)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
            counter++;
        }

        if (connectTo == null) head = prev;
        else connectTo.next = prev;

        end.next = current;

        return head;
    }
}
