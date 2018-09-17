/**
 * @param {number} x
 * @param {number} y
 * @return {number}
 */
var hammingDistance = function (x, y) {
    var z = x ^ y;
    var binaryZ = z.toString(2);
    var one = '1';
    var result = 0;

    for (var i = 0, l = binaryZ.length; i < l; i++) {
        if (binaryZ[i] === one) result++;
    }

    return result;
};
