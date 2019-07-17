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
    public ListNode SortList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }

        ListNode prev = null;
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }

        prev.next = null;

        ListNode begin = SortList(head);
        ListNode mid = SortList(slow);

        return MergeLists(begin, mid);
    }

    private ListNode MergeLists(ListNode node1, ListNode node2)
    {
        ListNode dummy = new ListNode(0);
        ListNode temp = dummy;

        while (node1 != null && node2 != null)
        {
            if (node1.val < node2.val)
            {
                temp.next = node1;
                node1 = node1.next;
            }
            else
            {
                temp.next = node2;
                node2 = node2.next;
            }

            temp = temp.next;
        }

        temp.next = node1 ?? node2;

        return dummy.next;
    }
}
