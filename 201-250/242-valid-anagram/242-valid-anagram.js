/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function (s, t) {
    var l = s.length;
    if (l !== t.length) return false;

    var map = {};

    for (var i = 0; i < l; i++) {
        var sChar = s[i];

        if (map[sChar] === undefined) {
            map[sChar] = 1;
        } else {
            map[sChar] += 1;
        }


        var tChar = t[i];

        if (map[tChar] === undefined) {
            map[tChar] = -1;
        } else {
            map[tChar] -= 1;
        }
    }

    for (var key in map) {
        if (map[key] !== 0) {
            return false;
        }
    }

    return true;
};
