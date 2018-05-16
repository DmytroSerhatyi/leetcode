/**
 * @param {number} n
 * @return {string}
 */
var countAndSay = function (n) {
    var sequence = '1';

    if (n === 1) return sequence;

    for (var i = 1; i < n; i++) {
        sequence = generateSay(sequence);
    }

    return sequence;
};

function generateSay(initial) {
    var result = '';
    var counter = 1;
    var symbol = initial[0];

    for (var i = 1, l = initial.length; i < l; i++) {
        var curr = initial[i];

        if (symbol === curr) {
            counter++;
        } else {
            result += counter + symbol;
            symbol = curr;
            counter = 1;
        }
    }

    result += counter + symbol;

    return result;
}
