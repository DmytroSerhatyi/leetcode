/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function (s) {
    var map = {
        '[': ']',
        '{': '}',
        '(': ')'
    };
    var helper = [];

    for (var i = 0, l = s.length; i < l; i++) {
        var char = s[i];

        if (map[char]) {
            helper.push(char);
        } else {
            var last = helper.pop();

            if (char !== map[last]) {
                return false;
            }
        }
    }

    return helper.length === 0;
};
