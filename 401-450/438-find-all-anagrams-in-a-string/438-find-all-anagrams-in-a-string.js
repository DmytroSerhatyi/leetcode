/**
 * @param {string} s
 * @param {string} p
 * @return {number[]}
 */
var findAnagrams = function (s, p) {
    var pMap = {};
    var result = [];
    var pl = p.length;
    var sl = s.length - pl + 1;
    var i, j, tempL;

    for (i = 0; i < pl; i++) {
        var pChar = p[i];

        if (!pMap[pChar]) pMap[pChar] = 0;

        pMap[pChar]++;
    }

    for (i = 0; i < sl; i++) {
        var sChar = s[i];

        if (pMap[sChar]) {
            var compareMaps = true;
            var map = {};
            map[sChar] = 1;

            for (j = i + 1, tempL = pl + i; j < tempL; j++) {
                var tempChar = s[j];

                if (pMap[tempChar]) {
                    if (!map[tempChar]) map[tempChar] = 0;

                    map[tempChar]++;
                } else {
                    compareMaps = false;
                    i = j;
                    break;
                }
            }

            if (compareMaps) {
                var match = true;

                for (var key in pMap) {
                    if (!pMap.hasOwnProperty(key)) continue;

                    if (pMap[key] !== map[key]) {
                        match = false;
                        break;
                    }
                }

                if (match) {
                    result.push(i);
                }
            }
        }
    }

    return result;
};
