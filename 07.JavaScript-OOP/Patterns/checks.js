var validators = {
    // Undefined
    checkUndefinedAndThrow: function(value) {
        if (value === undefined) {
            throw new Error(value + ' is undefined');
        }
    },
    // Integer
    isInteger: function(value) {
        this.checkUndefinedAndThrow(value);
        return typeof value === "number" && value === +value && Math.round(value) === value;
    },
    checkIntegerAndThrow: function(value) {
        this.checkUndefinedAndThrow(value);
        if (!this.isInteger(value)) {
            throw new Error(value + ' not a integer!');
        }
    },
    // Positive integer
    isPositiveInteger: function(value) {
        this.checkUndefinedAndThrow(value);
        return typeof value === "number" && value === +value && Math.round(value) === value && value >= 0;
    },
    checkPositiveIntegerAndThrow: function(value) {
        this.checkUndefinedAndThrow(value);
        if (!this.isPositiveInteger(value)) {
            throw new Error(value + ' not a positive integer!');
        }
    },
    // Float
    isFloat: function(value) {
        this.checkUndefinedAndThrow(value);
        return typeof value === "number" && value === +value && Math.round(value) !== value;
    },
    checkFloatAndThrow: function(value) {
        this.checkUndefinedAndThrow(value);
        if (!this.isFloat(value)) {
            throw new Error(value + ' not a float!');
        }
    },
    // Number
    isNumber: function(value) {
        this.checkUndefinedAndThrow(value);
        return !isNaN(parseFloat(value)) && isFinite(value);
    },
    checkNumberAndThrow: function(value) {
        this.checkUndefinedAndThrow(value);
        if (!this.isNumber(value)) {
            throw new Error(value + ' not a number!');
        }
    },
    // String
    isString: function(value) {
        this.checkUndefinedAndThrow(value);
        return (typeof value === 'string' || value instanceof String);
    },

    checkStringAndThrow: function(value) {
        this.checkUndefinedAndThrow(value);
        if (!this.isString(value)) {
            throw new Error(value + ' not a string!');
        }
    },
    // Boolean
    isBoolean: function(value) {
        this.checkUndefinedAndThrow(value);
        return typeof value === 'boolean' || value === 'true' || value === 'false';
    },
    checkBooleanAndThrow: function(value) {
        if (!this.isBoolean(value)) {
            this.checkUndefinedAndThrow(value);
            throw new Error(value + ' not a boolean!');
        }
    },
    // Array
    isArray: function(value) {
        this.checkUndefinedAndThrow(value);
        return Array.isArray(value);
    },
    checkArrayAndThrow: function(value) {
        this.checkUndefinedAndThrow(value);
        if (!this.isArray(value)) {
            throw new Error(value + ' not a array!');
        }
    },
    // Object
    isObject: function(value) {
        this.checkUndefinedAndThrow(value);
        return Object.prototype.toString.call(value) === '[object Object]';
    },
    checkObjectAndThrow: function(value) {
        this.checkUndefinedAndThrow(value);
        if (!this.isObject(value)) {
            throw new Error(value + ' not a object!');
        }
    }
};
