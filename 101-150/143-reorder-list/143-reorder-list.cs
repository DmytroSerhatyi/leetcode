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
    public void ReorderList(ListNode head)
    {
        if (head == null)
        {
            return;
        }

        IList<ListNode> list = new List<ListNode>();
        ListNode node = head;

        while (node != null)
        {
            list.Add(node);
            node = node.next;
        }

        node = head.next = list.Last();

        for (int i = 1; i < list.Count / 2; i++)
        {
            node = node.next = list[i];
            node = node.next = list[list.Count - 1 - i];
        }

        if (list.Count % 2 == 1)
        {
            node = node.next = list[list.Count / 2];
        }

        node.next = null;
    }
}
