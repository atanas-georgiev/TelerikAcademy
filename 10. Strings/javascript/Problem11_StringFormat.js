//Problem 11. String format
//
//Write a function that formats a string using placeholders.
//    The function should work with up to 30 placeholders and all types.
//    Examples:
//
//var str = stringFormat('Hello {0}!', 'Peter');
////str = 'Hello Peter!';
//
//var frmt = '{0}, {1}, {0} text {2}';
//var str = stringFormat(frmt, 1, 'Pesho', 'Gosho');
////str = '1, Pesho, 1 text Gosho'

var input = ["{0}, {1}, {0} text {2}", 1, "Pesho", "Gosho"];

function replacePlaceholder(text) {
    'use strict';
    var index = parseInt(text.replace('{', '').replace('}', ''), 10);
    return input[index + 1];
}

function modifyAllBetween(text, marker1, marker2, func) {
    'use strict';
    var i,
        reg = new RegExp(marker1 + '(.*?)' + marker2, 'g'),
        elements = text.match(reg);

    for (i = 0; i < elements.length; i += 1) {
        text = text.replace(elements[i], func(elements[i]));
    }

    return text;
}

function problem11_StringFormat() {
    'use strict';

    var result = modifyAllBetween(input[0], '{', '}', replacePlaceholder);
    console.log(result);
}