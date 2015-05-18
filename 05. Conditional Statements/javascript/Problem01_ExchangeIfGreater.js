//  Problem 1. Exchange if greater
//
//    Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//    As a result print the values a and b, separated by a space.

function problem01_ExchangeIfGreater() {

    alert('Problem 1. Exchange if greater');

    var a = prompt("a = "),
        b = prompt("b = "),
        temp;

    if (a > b) {
        temp  = a;
        a = b;
        b = temp;
    }

    alert('a = ' + a + ', b = ' + b);

}