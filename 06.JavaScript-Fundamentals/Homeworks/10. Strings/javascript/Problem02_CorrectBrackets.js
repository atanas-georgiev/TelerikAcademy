//Problem 2. Correct brackets
//
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

function areBracketsCorrect(input) {
    'use strict';

    var i,
        helpArray = [];

    if ((typeof input) !== 'string') {
        throw new Error('Input is not a string!');
    }

    for (i = 0; i < input.length; i += 1) {
        if (input[i] === '(') {
            helpArray.push(true);
        } else if (input[i] === ')') {
            if (helpArray.length !== 0) {
                helpArray.pop();
            } else {
                return false;
            }
        }
    }

    if (helpArray.length !== 0) {
        return false;
    } else {
        return true;
    }
}


function problem02_CorrectBrackets() {
    'use strict';
    alert('Are brackets correct? ' + areBracketsCorrect(prompt('Enter a string value')));
}