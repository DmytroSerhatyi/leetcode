/**
 * @param {string} S
 * @param {number} K
 * @return {string}
 */
var licenseKeyFormatting = function (S, K) {
    var dash = '-';
    var result = '';
    var counter = 1;

    for (var i = S.length - 1; i >= 0; i--) {
        var char = S[i];

        if (char === dash) continue;

        if (counter === 0) {
            result = dash + result;
            counter++;
        }

        result = char + result;
        counter++;

        if (counter > K) counter = 0;
    }

    return result.toUpperCase();
};
