//Problem 8. Replace tags
//
//Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

function replaceData(text) {
    'use strict';
    return text.replace('<a href="', '[URL=').replace('">', ']').replace('</a>', '[/URL]');
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

function problem08_ReplaceTags() {
    'use strict';
    var input = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

    input = modifyAllBetween(input, '<a', '\/a>', replaceData);

    console.log(input);

}