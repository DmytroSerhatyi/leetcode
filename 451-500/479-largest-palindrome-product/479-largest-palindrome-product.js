/**
 * @param {number} n
 * @return {number}
 */
var largestPalindrome = function(n) {
    if (n === 1) return 9;

    var helper = Math.pow(10, n);
    var max = helper - 1;
    var edge = helper / 10;

    for (var half = max - 1; half > edge; half--) {
        var halfHelper = half;
        var pallindrome = half;

        while (halfHelper > 0) {
            var remainder = halfHelper % 10;
            pallindrome = pallindrome * 10 + remainder;
            halfHelper = (halfHelper - remainder) / 10;
        }

        var overflowedPallindrome = !isPalindrome(pallindrome);

        if (overflowedPallindrome) pallindrome -= 2;

        for (var i = max; i * i >= pallindrome; i--) {
            var checker = overflowedPallindrome ? i - 1 : 0;

            if (pallindrome % i === checker) {
                var result = pallindrome % 1337;

                return overflowedPallindrome ? result + 1 : result;
            }
        }
    }

    function isPalindrome(num) {
        var str = num.toString();
        var i = 0;
        var j = str.length - 1;

        while (i < j) {
            if (str[i] !== str[j]) return false;

            i++;
            j--;
        }

        return true;
    }
};
