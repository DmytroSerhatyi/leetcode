/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var reverseList = function (head) {
    if (!head || !head.next) return head;

    var next = head;
    var result = null;

    while (next) {
        var temp = next.next;
        next.next = result;
        result = next;
        next = temp;
    }

    return result;
};
