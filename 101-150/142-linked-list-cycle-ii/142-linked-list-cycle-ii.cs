/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
    public ListNode DetectCycle(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;

        while (fast != null && fast.next != null && fast.next != slow)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        if (fast == null || fast.next == null)
        {
            return null;
        }
        else
        {
            fast = slow.next;
            slow = head;
        }

        while (fast != slow)
        {
            fast = fast.next;
            slow = slow.next;
        }

        return fast;
    }
}
