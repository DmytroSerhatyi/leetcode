/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */
var removeElement = function (nums, val) {
    var i = 0;
    var length = nums.length;

    while (i < length) {
        if (nums[i] === val) {
            nums[i] = nums[length - 1];
            length--;
        } else {
            i++;
        }
    }

    return length;
};
