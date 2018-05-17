/**
 * @param {number} x
 * @return {number}
 */
var reverse = function (x) {
    var limit = Math.pow(2, 31);
    var result = 0;
    var neg, lastDigit;

    if (x < 0) {
        x = Math.abs(x);
        neg = true;
    }

    while (x !== 0) {
        lastDigit = x % 10;
        result *= 10;
        result += lastDigit;
        x = parseInt(x / 10);
    }

    if (result > limit - 1 || result < -limit) {
        return 0;
    }

    return neg ? -result : result;
};
