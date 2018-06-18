/**
 * @param {string} s
 * @param {string} t
 * @return {character}
 */
var findTheDifference = function (s, t) {
    var n = 0;
    var x = s + t;
    var l = x.length;

    for (var i = 0; i < l; i++) {
        n ^= x.charCodeAt(i);
    }

    return String.fromCharCode(n);
};
