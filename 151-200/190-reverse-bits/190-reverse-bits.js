/**
 * @param {number} n - a positive integer
 * @return {number} - a positive integer
 */
var reverseBits = function (n) {
    var result = 0;

    for (var i = 0; i < 32; i++) {
        var result = result * 2 + (n & 1);
        n >>= 1;
    }

    return result;
};
