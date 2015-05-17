//Problem 5. Digit as word
//
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//    Use a switch statement.

(function () {

    var digit = prompt("Enter a digit: ");

    var a = -0.1,
        b = -1.1,
        c = -2,
        result = [];

    console.log('----------------------------------------');
    console.log('Problem 4. Sort 3 numbers');
    console.log('----------------------------------------');

    console.log('a = ' + a + ',b = ' + b + ',c = ' + c);

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

    console.log('result: ' + result);

})();