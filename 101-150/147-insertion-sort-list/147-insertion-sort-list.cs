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
    public ListNode InsertionSortList(ListNode head)
    {
        if (head == null)
        {
            return null;
        }

        ListNode result = head;

        head = head.next;
        result.next = null;

        while (head != null)
        {
            ListNode next = head.next;
            ListNode tempResult = result;

            head.next = null;

            if (tempResult.val > head.val)
            {
                head.next = tempResult;
                result = head;
            }
            else
            {
                ListNode nextResult = tempResult.next;

                while (tempResult != null && nextResult != null)
                {
                    if (nextResult.val >= head.val)
                    {
                        tempResult.next = head;
                        head.next = nextResult;
                        break;
                    }

                    tempResult = nextResult;
                    nextResult = nextResult.next;
                }

                if (tempResult.next == null)
                {
                    tempResult.next = head;
                }
            }

            head = next;
        }

        return result;
    }
}
