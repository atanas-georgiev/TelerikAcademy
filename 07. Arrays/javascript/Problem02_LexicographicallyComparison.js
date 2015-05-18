//Problem 2. Lexicographically comparison
//
//Write a script that compares two char arrays lexicographically (letter by letter).

function problem02_LexicographicallyComparison() {

    var a = prompt('a = '),
        b = prompt('b = '),
        len = a.length < b.length ? a.length : b.length,
        equal = true,
        cnt;

    for (cnt = 0; cnt < len; cnt++) {
        if (a[cnt] > b[cnt]) {
            alert('string a is greater');
            equal = false;
            break;
        } else if (a[cnt] < b[cnt]) {
            alert('string b is greater');
            equal = false;
            break;
        }
    }

    if (equal === true) {
        if (a.length > b.length) {
            alert('string a is greater');
        } else if (a.length < b.length) {
            alert('string b is greater');
        } else {
            alert('equal');
        }
    }

}