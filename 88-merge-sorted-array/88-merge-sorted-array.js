/**
 * @param {number[]} nums1
 * @param {number} m
 * @param {number[]} nums2
 * @param {number} n
 * @return {void} Do not return anything, modify nums1 in-place instead.
 */
var merge = function (nums1, m, nums2, n) {
    var j = nums1.length - 1;

    while (m || n) {
        var num1 = nums1[m - 1];
        var num2 = nums2[n - 1];
        var num1Greater = m > 0 && n > 0 ? num1 > num2 : m > 0;

        if (num1Greater) {
            nums1[j] = num1;
            m--;
        } else {
            nums1[j] = num2;
            n--;
        }
        j--;
    }
};
