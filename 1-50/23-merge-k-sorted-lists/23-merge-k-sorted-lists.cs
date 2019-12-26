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
    public ListNode MergeKLists(ListNode[] lists)
    {
        int interval = 1;
        int length = lists.Length;

        while (interval < length)
        {
            for (int i = 0; i + interval < length; i += interval * 2)
            {
                lists[i] = MergeTwoLists(lists[i], lists[i + interval]);
            }

            interval *= 2;
        }

        return length > 0 ? lists[0] : null;
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode node = new ListNode(0);
        ListNode head = node;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                node.next = list1;
                node = node.next;
                list1 = list1.next;
            }
            else
            {
                node.next = list2;
                node = node.next;
                list2 = list2.next;
            }
        }

        node.next = list1 ?? list2;

        return head.next;
    }
}
