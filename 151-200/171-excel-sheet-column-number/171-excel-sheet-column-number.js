/**
 * @param {string} s
 * @return {number}
 */
var titleToNumber = function (s) {
    var aCodeAdapted = 'A'.charCodeAt(0) - 1;
    var LETTERS_NUMBER = 26;
    var result = 0;

    for (var i = 0, l = s.length; i < l; i++) {
        result = result * LETTERS_NUMBER + (s[i].charCodeAt(0) - aCodeAdapted);
    }

    return result;
};
