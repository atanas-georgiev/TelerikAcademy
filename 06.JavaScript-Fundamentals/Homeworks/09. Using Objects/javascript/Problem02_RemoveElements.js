//Problem 2. Remove elements
//
//Write a function that removes all elements with a given value.
//    Attach it to the array type.
//    Read about prototype and how to attach methods.
//
//    var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];
//arr.remove(1); //arr = [2,4,3,4,111,3,2,'1'];

Array.prototype.RemoveElements = function (element) {
    'use strict';
    var index;

    while (true) {
        index = this.indexOf(element);
        if (index !== -1) {
            this.splice(index, 1);
        } else {
            break;
        }
    }

    return this;
};

function problem02_RemoveElements() {
    'use strict';
    var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
    alert('Array before operation: ' + arr);
    arr.RemoveElements(1);
    alert('Array after operation: ' + arr);
}