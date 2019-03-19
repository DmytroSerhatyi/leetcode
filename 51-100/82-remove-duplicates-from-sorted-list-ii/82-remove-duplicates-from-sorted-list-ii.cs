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
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null) return null;

        ListNode result = null;
        ListNode helper = null;
        ListNode next = head.next;

        while (head != null)
        {
            if (next == null || head.val != next.val)
            {
                if (result == null) result = helper = head;
                else helper = helper.next = head;

                helper.next = null;
            }
            else while (next != null && head.val == next.val) next = next.next;

            head = next;
            next = next?.next;
        }

        return result;
    }
}
