/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function (nums, target) {
    var low = 0,
        high = nums.length - 1;

    while (low <= high) {
        var mid = parseInt((high + low) / 2);
        var midNum = nums[mid];

        if (midNum === target) {
            return mid;
        } else if (midNum > target) {
            high = mid - 1;
        } else {
            low = mid + 1;
        }
    }

    return low;
};
