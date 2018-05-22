/**
 * @param {number[]} nums
 * @param {number} k
 * @return {void} Do not return anything, modify nums in-place instead.
 */
var rotate = function (nums, k) {
    var l = nums.length;
    k = k % l;
    var counter = 0;

    for (var i = 0; counter < l; i++) {
        var current = i;
        var prev = nums[i];

        do {
            var next = (current + k) % l;
            var temp = nums[next];
            nums[next] = prev;
            prev = temp;
            current = next;
            counter++;
        } while (i !== current);
    }
};
