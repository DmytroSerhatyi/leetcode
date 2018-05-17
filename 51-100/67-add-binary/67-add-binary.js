/**
 * @param {string} a
 * @param {string} b
 * @return {string}
 */
var addBinary = function (a, b) {
    var zero = '0',
        one = '1',
        aL = a.length,
        bL = b.length,
        diff = aL - bL,
        result = '',
        forwardOne = false,
        shorter, longer;

    if (diff > 0) {
        longer = a;
        shorter = b;
    } else {
        longer = b;
        shorter = a;
    }

    diff = Math.abs(diff);

    while (diff) {
        shorter = zero + shorter;
        diff--;
    }

    for (var i = longer.length - 1; i >= 0; i--) {
        var lChar = longer[i];
        var sChar = shorter[i];

        if (lChar === sChar) {
            result = (forwardOne ? one : zero) + result;

            forwardOne = lChar === one;
        } else {
            result = (forwardOne ? zero : one) + result;
        }
    }

    if (forwardOne) {
        result = one + result;
    }

    return result;
};
