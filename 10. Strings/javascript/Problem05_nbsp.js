//Problem 5. nbsp
//
//Write a function that replaces non breaking white-spaces in a text with &nbsp;

function whiteSpaceEscape(text) {
    'use strict';
    return text.replace(/ /g, '&nbsp;');
}

function problem05_nbsp() {
    'use strict';
    var text = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.';

    alert(whiteSpaceEscape(text));
}