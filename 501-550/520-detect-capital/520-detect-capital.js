/**
 * @param {string} word
 * @return {boolean}
 */
var detectCapitalUse = function (word) {
    var l = word.length;
    var capitals = 0;

    for (var i = 0; i < l; i++) {
        var letter = word[i];

        if (letter === letter.toUpperCase()) capitals++;
    }

    return capitals === 0 || capitals === l || (capitals === 1 && word[0].toUpperCase() === word[0]);
};
