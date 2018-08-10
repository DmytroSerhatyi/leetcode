/**
 * @param {character[]} chars
 * @return {number}
 */
var compress = function (chars) {
    if (!chars.length) return 0;

    var anchor = 0;
    var counter = 1;

    for (var i = 0, l = chars.length; i < l; i++) {
        var char = chars[i];
        var nextChar = chars[i + 1];

        if (char === nextChar) {
            counter++;
        } else {
            chars[anchor++] = char;

            if (counter > 1) {
                var str = counter + '';

                for (var j = 0, jl = str.length; j < jl; j++) {
                    chars[anchor++] = str[j];
                }
            }

            counter = 1;
        }
    }

    return anchor;
};
