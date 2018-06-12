/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var intersect = function (nums1, nums2) {
    var map = {};
    var i = 0;
    var l = nums1.length;
    var result = [];
    var num;

    for (; i < l; i++) {
        num = nums1[i];

        if (!map[num]) {
            map[num] = 0;
        }

        map[num]++;
    }

    for (i = 0, l = nums2.length; i < l; i++) {
        num = nums2[i];

        if (map[num]) {
            result.push(num);
            map[num]--;
        }
    }

    return result;
};
