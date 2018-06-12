/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */
var intersection = function (nums1, nums2) {
    var map1 = {};
    var i = 0;
    var l = nums1.length;

    for (; i < l; i++) {
        map1[nums1[i]] = true;
    }

    var map2 = {};

    for (i = 0, l = nums2.length; i < l; i++) {
        var num = nums2[i];

        if (map1[num]) map2[num] = true;
    }

    var result = [];

    for (var key in map2) {
        if (map2.hasOwnProperty(key)) {
            result.push(+key);
        }
    }

    return result;
};
