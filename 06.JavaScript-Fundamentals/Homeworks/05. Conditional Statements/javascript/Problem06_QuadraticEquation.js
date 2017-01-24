//  Problem 6. Quadratic equation
//
//  Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//  Calculates and prints its real roots.
//    Note: Quadratic equations may have 0, 1 or 2 real roots.

function problem06_QuadraticEquation() {

    alert('Problem 6. Quadratic equation');

    var a = prompt("a = "),
        b = prompt("b = "),
        c = prompt("c = "),
        sqrtpart = (b * b) - 4 * (a * c),
        x1,
        x2;

    if (sqrtpart > 0) {
        x1 = (-b + Math.sqrt(sqrtpart)) / (2 * a);
        x2 = (-b - Math.sqrt(sqrtpart)) / (2 * a);
    } else if (sqrtpart < 0) {
        x1 = 'no real root';
        x2 = 'no real root';
    } else {
        x1 = (-b + Math.sqrt(sqrtpart)) / (2 * a);
        x2 = x1;
    }

    alert('x1 = ' + x1 + ', x2 = ' + x2);

}