/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {boolean}
 */
var isPalindrome = function (head) {
    var arr = [];

    while (head) {
        arr.push(head.val);
        head = head.next;
    }

    var length = arr.length;
    var l = length / 2;
    var i = 0;
    var j = length - 1;

    while (i < l) {
        if (arr[i] !== arr[j]) return false;

        i++;
        j--;
    }

    return true;
};
