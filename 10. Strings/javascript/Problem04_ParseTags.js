//Problem 4. Parse tags
//
//You are given a text. Write a function that changes the text in all regions:
//
//    <upcase>text</upcase> to uppercase.
//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)
//Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.
//
//The expected result:
//    We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.
//
//Note: Regions can be nested.

function toUpper(text) {
    'use strict';
    var textInTags = text.match(/>(.*?)</g);
    return text.replace(textInTags[0], textInTags[0].toUpperCase());
}

function toLower(text) {
    'use strict';
    var textInTags = text.match(/>(.*?)</g);
    return text.replace(textInTags[0], textInTags[0].toLowerCase());
}

function toRandom(text) {
    'use strict';
    var textInTags = text.match(/>(.*?)</g),
        modified = '',
        i;

    for (i = 0; i < textInTags[0].length; i += 1) {
        if (Math.random() < 0.5) {
            modified += textInTags[0].substr(i, 1).toUpperCase();
        } else {
            modified += textInTags[0].substr(i, 1).toLowerCase();
        }
    }

    return text.replace(textInTags, modified);
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

function problem04_ParseTags() {
    'use strict';
    var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>dont</mixcase> have <lowcase>ANYTHING</lowcase> else';

    text = modifyAllBetween(text, '<upcase>', '<\/upcase>', toUpper);
    text = modifyAllBetween(text, '<lowcase>', '<\/lowcase>', toLower);
    text = modifyAllBetween(text, '<mixcase>', '<\/mixcase>', toRandom);

    alert(text);

}