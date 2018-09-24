/**
 * @param {number} num
 * @return {number}
 */
var findComplement = function (num) {
    var bits = num.toString(2);
    var complementBits = '';
    var zero = '0';
    var one = '1';

    for (var i = 0, l = bits.length; i < l; i++) complementBits += bits[i] === zero ? one : zero;

    return parseInt(complementBits, 2);
};
