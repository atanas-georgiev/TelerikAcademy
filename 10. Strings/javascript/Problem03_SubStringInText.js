//Problem 3. Sub-string in text
//
//Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example:
//
//    The target sub-string is in
//
//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//
//The result is: 9

function countStringOccurances(thePattern, theString) {
    'use strict';
    return theString.match(eval('/' + thePattern + '/g')).length;
}

function problem03_SubStringInText() {
    'use strict';
    var text = prompt('Enter text'),
        srch = prompt('Enter search text');

    alert('Number of occurrences: ' + countStringOccurances(srch, text));

}