//  Problem 3. The biggest of Three
//
//  Write a script that finds the biggest of three numbers.
//  Use nested if statements.

function problem03_TheBiggestOfThree() {

    alert('Problem 3. The biggest of Three');

    var a = prompt("a = "),
        b = prompt("b = "),
        c = prompt("c = "),
        result;

    if (a >= b) {
        if (a >= c) {
            result = a;
        } else {
            result = c;
        }
    } else {
        if (b >= c) {
            result = b;
        } else {
            result = c;
        }
    }

    alert('result: ' + result);

}