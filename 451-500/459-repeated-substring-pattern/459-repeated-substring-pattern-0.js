/**
 * @param {string} s
 * @return {boolean}
 */
var repeatedSubstringPattern = function (s) {
    if (s.length < 2) return false;

    var substr = '';

    for (var i = 0, l = s.length / 2; i < l; i++) {
        substr += s[i];
        var subl = substr.length;
        var result = true;

        for (var j = subl, sl = s.length; j < sl; j += subl) {
            if (substr !== s.substr(j, subl)) {
                result = false;
                break;
            }
        }

        if (result) return result;
    }

    return false;
};
