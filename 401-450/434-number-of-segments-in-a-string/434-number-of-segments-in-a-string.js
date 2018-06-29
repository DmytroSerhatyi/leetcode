/**
 * @param {string} s
 * @return {number}
 */
var countSegments = function (s) {
    var result = 0;
    var space = ' ';

    for (var i = 0, l = s.length; i < l; i++) {
        if ((i === 0 || s[i - 1] === space) && s[i] !== space) result++;
    }

    return result;
};
