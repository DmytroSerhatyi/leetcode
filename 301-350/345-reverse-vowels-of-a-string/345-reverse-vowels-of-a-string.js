/**
 * @param {string} s
 * @return {string}
 */
var reverseVowels = function (s) {
    var map = {
        a: true,
        e: true,
        i: true,
        o: true,
        u: true
    };

    var l = s.length;
    var i = 0;
    var j = l;
    var arr = s.split('');
    s = s.toLowerCase();

    while (i < j) {
        while (!map[s[i]] && i < l) i++;

        while (!map[s[j]] && j >= 0) j--;

        if (i >= j) break;

        var temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        i++;
        j--;
    }

    return arr.join('');
};
