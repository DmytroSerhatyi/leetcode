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
    public ListNode Partition(ListNode head, int x)
    {
        ListNode begin = null;
        ListNode beginHelper = null;
        ListNode end = null;
        ListNode endHelper = null;

        while (head != null)
        {
            if (head.val < x)
            {
                if (begin == null) begin = head;

                if (beginHelper == null) beginHelper = begin;
                else beginHelper = beginHelper.next = head;
            }
            else
            {
                if (end == null) end = head;

                if (endHelper == null) endHelper = end;
                else endHelper = endHelper.next = head;
            }

            head = head.next;
        }

        if (endHelper != null) endHelper.next = null;

        if (begin != null)
        {
            beginHelper.next = end;

            return begin;
        }

        return end;
    }
}
