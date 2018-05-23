/**
 * @param {number} n - a positive integer
 * @return {number}
 */
var hammingWeight = function (n) {
    var result = 0;

    while (n !== 0) {
        result++;
        n &= (n - 1);
    }

    return result;
};
