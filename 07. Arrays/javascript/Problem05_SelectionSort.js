//Problem 5. Selection sort
//
//Sorting an array means to arrange its elements in increasing order.
//    Write a script to sort an array.
//    Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
//    Hint: Use a second array

function problem05_SelectionSort() {

    var numbers = [],
        value,
        min,
        i,
        j,
        temp;

    while (value = prompt('Enter number (Enter to exit)')) {
        numbers.push(parseInt(value));
    }

    for (i = 0; i < numbers.length - 1; i++) {
        min = i;
        for (j = i + 1; j < numbers.length; j++) {
            if (numbers[j] < numbers[min]) {
                min = j;
            }
        }

        if (min !== i) {
            // swap values
            temp = numbers[i];
            numbers[i] = numbers[min];
            numbers[min] = temp;
        }
    }

    alert('sorted array: ' + numbers);

}