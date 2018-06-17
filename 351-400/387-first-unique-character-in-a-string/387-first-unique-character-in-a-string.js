/**
 * @param {string} s
 * @return {number}
 */
var firstUniqChar = function (s) {
    var map = {};
    var l = s.length;
    var i, c;

    for (i = 0; i < l; i++) {
        c = s[i];

        if (!map[c]) map[c] = 0;

        map[c]++;
    }

    for (i = 0; i < l; i++) {
        c = s[i];

        if (map[c] === 1) return i;
    }

    return -1;
};
