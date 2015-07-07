// Integer
function isInteger(value) {
    'use strict';
    return typeof value === "number" && value === +value && Math.round(value) === value;
}

function checkIntegerAndThrow(value) {
    'use strict';
    if (!isInteger(value)) {
        throw new Error(value + ' not a integer!');
    }
}

// Positive integer
function isPositiveInteger(value) {
    'use strict';
    return typeof value === "number" && value === +value && Math.round(value) === value && value >= 0;
}

function checkPositiveIntegerAndThrow(value) {
    'use strict';
    if (!isPositiveInteger(value)) {
        throw new Error(value + ' not a positive integer!');
    }
}

// Float
function isFloat(value) {
    'use strict';
    return typeof value === "number" && value === +value && Math.round(value) !== value;
}

function checkFloatAndThrow(value) {
    'use strict';
    if (!isFloat(value)) {
        throw new Error(value + ' not a float!');
    }
}

// Number
function isNumber(value) {
    'use strict';
    return !isNaN(parseFloat(value)) && isFinite(value);
}

function checkNumberAndThrow(value) {
    'use strict';
    if (!isNumber(value)) {
        throw new Error(value + ' not a number!');
    }
}

// String
function isString(value) {
    'use strict';
    return (typeof value === 'string' || value instanceof String);
}

function checkStringAndThrow(value) {
    'use strict';
    if (!isString(value)) {
        throw new Error(value + ' not a string!');
    }
}

// Boolean
function isBoolean(value) {
    'use strict';
    return typeof value === 'boolean' || value === 'true' || value === 'false';
}

function checkBooleanAndThrow(value) {
    'use strict';
    if (!isBoolean(value)) {
        throw new Error(value + ' not a boolean!');
    }
}

// Array
function isArray(value) {
    'use strict';
    return Array.isArray(value);
}

function checkArrayAndThrow(value) {
    'use strict';
    if (!isArray(value)) {
        throw new Error(value + ' not a array!');
    }
}

// Object
function isObject(value) {
    'use strict';
    return Object.prototype.toString.call(value) === '[object Object]';
}

function checkObjectAndThrow(value) {
    'use strict';
    if (!isObject(value)) {
        throw new Error(value + ' not a object!');
    }
}


console.log(isObject(1.11));
console.log(isObject({}));
console.log(isObject("true"));
console.log(isObject());
console.log(isObject(null));
