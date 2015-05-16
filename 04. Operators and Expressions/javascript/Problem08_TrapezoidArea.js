//  Problem 8. Trapezoid area
//  Write an expression that calculates trapezoid's area by given sides a and b and height h.

function calculateTrapezoidArea(a, b, h) {
    if (isNaN(a) || isNaN(b) || isNaN(h)) {
        return null;
    }

    return ((a + b) / 2) * h;
}

console.log('----------------------------------------');
console.log('Task 8 output: Trapezoid area');
console.log('----------------------------------------');

console.log("a = 5, b = 7, h = 12, area: " + calculateTrapezoidArea(5, 7, 12));
console.log("a = 100, b = 200, h = 300, area: " + calculateTrapezoidArea(100, 200, 300));
console.log("a = 0.222, b = 0.333, h = 0.444, area: " + calculateTrapezoidArea(0.222, 0.333, 0.444));