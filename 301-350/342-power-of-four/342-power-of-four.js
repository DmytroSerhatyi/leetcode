/**
 * @param {number} num
 * @return {boolean}
 */
var isPowerOfFour = function (num) {
    if (num < 1 || (num & (num - 1)) !== 0) return false;

    return num.toString(2).length % 2 === 1;
};
