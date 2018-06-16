/**
 * @param {string} ransomNote
 * @param {string} magazine
 * @return {boolean}
 */
var canConstruct = function (ransomNote, magazine) {
    if (ransomNote.length === 0) return true;

    var l = magazine.length;
    var map = {};
    var char;
    var i;

    for (i = 0; i < l; i++) {
        char = magazine[i];

        if (!map[char]) map[char] = 0;

        map[char]++;
    }

    l = ransomNote.length;

    for (i = 0; i < l; i++) {
        char = ransomNote[i];

        if (!map[char]) return false;

        map[char]--;
    }

    return true;
};
