/**
 * @param {string} haystack
 * @param {string} needle
 * @return {number}
 */
var strStr = function (haystack, needle) {
    if (!needle.length || needle === haystack) return 0;

    var needleL = needle.length;
    var diff = haystack.length - needleL;

    if (diff < 0) return -1;

    for (var i = 0, l = diff + 1; i < l; i++) {
        if (haystack[i] === needle[0]) {
            var j = 1;

            while (j < needleL) {
                if (haystack[i + j] !== needle[j]) break;
                j++;
            }
            if (j === needleL) {
                return i;
            }
        }
    }

    return -1;
};
