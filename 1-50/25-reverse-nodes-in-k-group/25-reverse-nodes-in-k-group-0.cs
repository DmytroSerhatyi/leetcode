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
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        ListNode result = null;
        ListNode firstItem = null;
        ListNode currentItem = null;
        ListNode lastItem = null;
        ListNode headNext;
        int index = 0;

        while (head != null)
        {
            headNext = head.next;

            if (index == 0)
            {
                firstItem = head;
                firstItem.next = null;
                currentItem = firstItem;
                index++;
            }
            else if (index <= k)
            {
                head.next = currentItem;
                currentItem = head;
                index++;
            }

            if (index == k)
            {
                if (result == null)
                {
                    result = currentItem;
                }

                if (lastItem != null)
                {
                    lastItem.next = currentItem;
                }

                lastItem = firstItem;
                index = 0;
            }

            head = headNext;
        }

        if (lastItem == null)
        {
            result = Reverse(currentItem);
        }
        else if (index > 0 && currentItem != null)
        {
            lastItem.next = Reverse(currentItem);
        }

        return result;
    }

    private ListNode Reverse(ListNode node)
    {
        if (node == null)
        {
            return null;
        }

        ListNode nodeNext;
        ListNode currentItem = null;

        while (node != null)
        {
            nodeNext = node.next;
            node.next = currentItem;
            currentItem = node;
            node = nodeNext;
        }

        return currentItem;
    }
}
