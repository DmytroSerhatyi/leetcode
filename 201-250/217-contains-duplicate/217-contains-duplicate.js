/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function (nums) {
    for (var i = 1, l = nums.length; i < l; i++) {
        var j = i;
        var pJ = j - 1;
        var prev = nums[pJ];
        var current = nums[j];

        while (prev > current) {
            nums[pJ] = current;
            nums[j] = prev;
            pJ--;
            j--;
            current = nums[j];
            prev = nums[pJ];
        }

        if (prev === current) {
            return true;
        }
    }

    return false;
};
