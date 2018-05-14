/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function (strs) {
    if (strs.length === 0) return '';
    if (strs.length === 1) return strs[0];

    var base = strs[0];

    for (var i = 1, l = strs.length; i < l; i++) {
        while (strs[i].indexOf(base) !== 0) {
            base = base.substring(0, base.length - 1);
            if (base.length === 0) {
                return '';
            }
        }
    }

    return base;
};
