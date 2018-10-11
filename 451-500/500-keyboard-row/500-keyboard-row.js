/**
 * @param {string[]} words
 * @return {string[]}
 */
var findWords = function (words) {
    var map = {
        q: 0, w: 0, e: 0, r: 0, t: 0, y: 0, u: 0, i: 0, o: 0, p: 0,
        a: 1, s: 1, d: 1, f: 1, g: 1, h: 1, j: 1, k: 1, l: 1,
        z: 2, x: 2, c: 2, v: 2, b: 2, n: 2, m: 2
    };
    var wordsHelper = [];
    var i, l;

    for (i = 0, l = words.length; i < l; i++) wordsHelper.push(words[i].toLowerCase());

    var result = [];

    for (i = 0, l = words.length; i < l; i++) {
        var word = wordsHelper[i];
        var row = map[word[0]];
        var add = true;

        for (var j = 1, m = word.length; j < m; j++) {
            if (map[word[j]] !== row) {
                add = false;
                break;
            }
        }

        if (add) result.push(words[i]);
    }

    return result;
};
