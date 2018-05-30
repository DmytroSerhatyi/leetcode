/**
 * @param {number[]} nums
 * @param {number} k
 * @return {boolean}
 */
var containsNearbyDuplicate = function (nums, k) {
    var map = {};

    for (var i = 0, l = nums.length; i < l; i++) {
        var num = nums[i];
        var j = map[num];

        if (j !== undefined && i - j <= k) {
            return true;
        }

        map[num] = i;
    }

    return false;
};
