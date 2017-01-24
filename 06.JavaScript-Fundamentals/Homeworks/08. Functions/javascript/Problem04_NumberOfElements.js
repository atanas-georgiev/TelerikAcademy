//Problem 4. Number of elements
//
//Write a function to count the number of div elements on the web page

function countDivElements(element) {
    'use strict';
    return document.getElementsByTagName(element).length;
}

function problem04_NumberOfElements() {
    'use strict';
    alert('Page contains ' + countDivElements('div') + " element(s).");
}