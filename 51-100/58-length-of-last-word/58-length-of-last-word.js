/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLastWord = function (s) {
    var length = 0;
    var space = ' ';
    var maxI = s.length - 1;

    for (var i = maxI; i >= 0; i--) {
        var symbol = s[i];

        if (symbol !== space) {
            length++;
        }

        if (length !== 0 && symbol === space) {
            break;
        }
    }

    return length;
};
