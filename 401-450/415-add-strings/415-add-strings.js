/**
 * @param {string} num1
 * @param {string} num2
 * @return {string}
 */
var addStrings = function (num1, num2) {
    var l1 = num1.length;
    var l2 = num2.length;
    var l, longStr, shortStr;

    if (l1 > l2) {
        l = l1;
        longStr = num1;
        shortStr = num2;
    } else {
        l = l2;
        longStr = num2;
        shortStr = num1;
    }

    while (shortStr.length !== longStr.length) {
        shortStr = '0' + shortStr;
    }

    var maxI = l - 1;
    var forwardOne = false;
    var result = '';

    for (var i = maxI; i >= 0; i--) {
        var char1 = +longStr[i];
        var char2 = +shortStr[i];
        var sum = char1 + char2;

        if (forwardOne) {
            sum++;
            forwardOne = false;
        }

        if (sum < 10 || i === 0) {
            result = sum + result;
        } else {
            result = sum - 10 + result;
            forwardOne = true;
        }
    }

    return result;
};
