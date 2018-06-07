/**
 * @param {string} pattern
 * @param {string} str
 * @return {boolean}
 */
var wordPattern = function (pattern, str) {
    var usedLetters = {};
    var usedWords = {};
    var j = 0;
    var ls = str.length;
    var maxI = ls - 1;

    for (var i = 0, l = pattern.length; i < l; i++) {
        var char = pattern[i];
        var word = usedLetters[char];
        var strWord = '';

        for (; j < ls; j++) {
            var strChar = str[j];

            if (strWord === '') {
                strWord += strChar;
            } else {
                if (strChar === ' ') {
                    if (j !== maxI) j++;
                    break;
                }

                strWord += strChar;
            }
        }

        if (strWord === '') return false;

        if (word) {
            if (word !== strWord) return false;
        } else {
            if (usedWords[strWord]) return false;

            usedLetters[char] = strWord;
            usedWords[strWord] = true;
        }
    }

    return j === ls;
};
