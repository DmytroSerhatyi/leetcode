/**
 * @param {number} num
 * @return {boolean}
 */
var isPerfectSquare = function (num) {
    if (num === 1) return true;

    var low = 2;
    var high = num;

    while (low < high) {
        var mid = parseInt((high + low) / 2);
        var sqr = mid * mid;

        if (sqr === num) {
            return true;
        } else if (sqr > num) {
            high = mid;
        } else {
            low = mid + 1;
        }
    }

    return false;
};
