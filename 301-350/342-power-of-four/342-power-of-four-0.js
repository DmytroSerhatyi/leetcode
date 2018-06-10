/**
 * @param {number} num
 * @return {boolean}
 */
var isPowerOfFour = function (num) {
    if (num < 1) return false;

    while (num % 4 === 0) num /= 4;

    return num === 1;
};
