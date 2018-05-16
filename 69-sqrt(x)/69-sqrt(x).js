/**
 * @param {number} x
 * @return {number}
 */
var mySqrt = function (x) {
    if (x === 0) return 0;

    var left = 1,
        right = x;

    while (left <= right) {
        var mid = left + Math.floor((right - left) / 2);

        if (mid === x / mid) {
            return mid;
        } else if (mid < x / mid) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }

    return right;
};
