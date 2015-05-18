//Problem 4. Lexicographically smallest
//
//Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

function problem04_LexicographicallySmallest() {

    var prop,
        list = [];

    for (prop in document) {
        list.push(prop);
    }

    alert('lexicographically smallest element in document object is: ' + list.sort()[0] + '\nlexicographically largest element in document object is: ' + list.sort()[list.length - 1]);

    for (prop in window) {
        list.push(prop);
    }

    alert('lexicographically smallest element in window object is: ' + list.sort()[0] + '\nlexicographically largest element in window object is: ' + list.sort()[list.length - 1]);

    for (prop in navigator) {
        list.push(prop);
    }

    alert('lexicographically smallest element in navigator object is: ' + list.sort()[0] + '\nlexicographically largest element in navigator object is: ' + list.sort()[list.length - 1]);
}