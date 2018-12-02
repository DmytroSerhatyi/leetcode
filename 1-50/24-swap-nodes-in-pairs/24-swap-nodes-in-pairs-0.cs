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
        if (head?.next == null) return head;

        ListNode first = head.next;
        ListNode second = head;
        ListNode others = first.next;

        first.next = second;
        second.next = SwapPairs(others);

        return first;
    }
}
