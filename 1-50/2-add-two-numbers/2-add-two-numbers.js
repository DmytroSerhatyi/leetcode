/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers = function (l1, l2) {
    if (!l1 && !l2) return;

    var carry = 0;
    var result;
    var temp;

    while (l1 || l2 || carry) {
        var val1 = l1 ? l1.val : 0;
        var val2 = l2 ? l2.val : 0;
        var val = val1 + val2 + carry;

        carry = 0;

        if (val >= 10) {
            carry = 1;
            val -= 10;
        }

        var helper = new ListNode(val);

        if (temp) temp = temp.next = helper;
        else temp = result = helper;

        if (l1) l1 = l1.next;
        if (l2) l2 = l2.next;
    }

    return result;
};
