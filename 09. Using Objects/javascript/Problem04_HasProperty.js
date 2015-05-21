//Problem 4. Has property
//
//Write a function that checks if a given object contains a given property.
//
//    var obj  = …;
//var hasProp = hasProperty(obj, 'length');

function hasProperty(obj, prop) {
    'use strict';

    return obj.hasOwnProperty(prop);
}

function problem04_HasProperty() {
    'use strict';

    var obj = window,
        prop = 'closed';

    if (hasProperty(obj, prop)) {
        alert('Object contains the property');
    } else {
        alert('Object do NOT contain the property');
    }
}