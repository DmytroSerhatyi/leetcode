/**
 * @param {string} pattern
 * @param {string} str
 * @return {boolean}
 */
var wordPattern = function (pattern, str) {
    var words = str.split(' ');
    var usedLetters = {};
    var usedWords = {};
    var l = pattern.length;

    if (words.length !== l) return false;

    for (var i = 0; i < l; i++) {
        var char = pattern[i];
        var word = usedLetters[char];
        var strWord = words[i];

        if (word) {
            if (word !== strWord) return false;
        } else {
            if (usedWords[strWord]) return false;

            usedLetters[char] = strWord;
            usedWords[strWord] = true;
        }
    }

    return true;
};
