//Problem 7. Binary search
//
//Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

function problem07_BinarySearch() {

    // Declare test array
    var array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 20, 34, 56, 78, 98, 99],
        value,
        start = 0,
        end = array.length - 1,
        mid = 0;

    // Enter search value
    value = prompt('Enter search value: ');

    // Binary search
    while (start <= end) {
        mid = Math.floor((start + end) / 2);

        if (array[mid] < value) {
            start = mid + 1;
        } else if (array[mid] > value) {
            end = mid - 1;
        } else {
            // Value found
            alert('Index is: ' + mid);
            return;
        }
    }

    alert('Value not found!');
}