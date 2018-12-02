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
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null) return head;

        ListNode first = head;
        ListNode second = head.next;
        ListNode dummy = new ListNode(0);

        dummy.next = head;
        head = dummy;

        while (second != null)
        {
            ListNode temp = second.next;

            head.next = second;
            first.next = temp;
            second.next = first;

            if (temp == null) break;

            head = first;
            first = temp;
            second = temp.next;
        }

        return dummy.next;
    }
}
