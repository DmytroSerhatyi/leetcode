/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isIsomorphic = function (s, t) {
    var map = {};
    var set = {};

    for (var i = 0, l = s.length; i < l; i++) {
        var key = s[i];
        var value = t[i];

        if (!map[key] && !set[value]) {
            map[key] = value;
            set[value] = true;
        }

        if (map[key] !== value) return false;
    }

    return true;
};
