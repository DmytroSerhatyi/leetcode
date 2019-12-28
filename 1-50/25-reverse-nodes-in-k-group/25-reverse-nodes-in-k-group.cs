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
        head = new ListNode(0) { next = head };

        ListNode last = head;

        while (last.next != null)
        {
            ListNode nextLast = last.next;

            for (int i = 1; i < k; i++)
            {
                ListNode current = last.next;
                ListNode next = current.next;
                ListNode target = current;
                int j = 0;

                while (j < k - i && target.next != null)
                {
                    target = target.next;
                    j++;
                }

                if (j != k - i)
                {
                    break;
                }

                current.next = target.next;
                target.next = current;
                last.next = next;
            }

            last = nextLast;
        }

        return head.next;
    }
}
