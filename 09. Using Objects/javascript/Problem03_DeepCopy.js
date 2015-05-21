//Problem 3. Deep copy
//
//Write a function that makes a deep copy of an object.
//    The function should work for both primitive and reference types.

function deepCopy(obj) {
    'use strict';
    var childObject,
        newObject = {};

    if (typeof obj !== 'object') {
        return obj;
    }

    for (childObject in obj) {
        newObject[childObject] = deepCopy(obj[childObject]);
    }

    return newObject;
}

function problem03_DeepCopy() {
    'use strict';
    var a = 5,
        b = {element: 'string object'};

    alert('a = ' + a + ', after deep copy = ' + deepCopy(a));
    alert('b = ' + b + ', after deep copy = ' + deepCopy(b));
}