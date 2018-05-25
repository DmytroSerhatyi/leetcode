/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} val
 * @return {ListNode}
 */
var removeElements = function (head, val) {
    if (!head) return null;

    while (head && head.val === val) {
        head = head.next;
    }

    var current = head;

    while (current) {
        if (current.next && current.next.val === val) {
            current.next = current.next.next;
        } else {
            current = current.next;
        }
    }

    return head;
};
