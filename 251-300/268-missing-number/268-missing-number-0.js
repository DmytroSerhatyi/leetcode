/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function (nums) {
    var l = nums.length
    var missing = l;

    for (var i = 0; i < l; i++) {
        missing ^= i ^ nums[i];
    }

    return missing;
};
