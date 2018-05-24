/**
 * @param {number[]} nums
 * @return {number}
 */
var rob = function (nums) {
    var robbed = 0;
    var notRobbed = 0;

    for (var i = 0, l = nums.length; i < l; i++) {
        var currentRobbed = notRobbed + nums[i];

        notRobbed = Math.max(robbed, notRobbed);

        robbed = currentRobbed;
    }

    return Math.max(robbed, notRobbed);
};
