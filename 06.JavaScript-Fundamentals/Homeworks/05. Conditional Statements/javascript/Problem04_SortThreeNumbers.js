//  Problem 4. Sort 3 numbers
//
//  Sort 3 real values in descending order.
//  Use nested if statements.
//  Note: Don’t use arrays and the built-in sorting functionality.

function problem04_SortThreeNumbers() {

    alert('Problem 4. Sort 3 numbers');

    var a = prompt("a = "),
        b = prompt("b = "),
        c = prompt("c = "),
        result = [];

    if (a >= b) {
        if (a >= c) {
            if (b >= c) {
                result.push(a, b, c); // (a > b) && (a > c) &&(b > c)
            } else {
                result.push(a, c, b); // (a > b) && (a > c) &&(c > b)
            }
        }
    } else if (b >= a) {
        if (b >= c) {
            if (a >= c) {
                result.push(b, a, c); // (b > a) && (b > c) &&(a > c)
            } else {
                result.push(b, c, a); // (b > a) && (b > c) &&(c > a)
            }
        }
    } else if (c >= a) {
        if (c >= b) {
            if (a >= b) {
                result.push(c, a, b); // (c > a) && (c > b) &&(a > b)
            } else {
                result.push(c, b, a); // (c > a) && (c > b) &&(b > a)
            }
        }
    }

    alert('result: ' + result);

}