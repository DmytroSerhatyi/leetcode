/**
 * Definition for isBadVersion()
 * 
 * @param {integer} version number
 * @return {boolean} whether the version is bad
 * isBadVersion = function(version) {
 *     ...
 * };
 */

/**
 * @param {function} isBadVersion()
 * @return {function}
 */
var solution = function (isBadVersion) {
    /**
     * @param {integer} n Total versions
     * @return {integer} The first bad version
     */
    return function (n) {
        var good = 0;
        var bad = n;

        while (bad - good !== 1) {
            var mid = parseInt((bad - good) / 2) + good;
            var isBad = isBadVersion(mid);

            if (isBad) {
                bad = mid;
            } else {
                good = mid;
            }
        }

        return bad;
    };
};
