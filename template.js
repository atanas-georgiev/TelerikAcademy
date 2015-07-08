function solve() {
    'use strict';

    var module = (function () {

        // Constants in the module
        var CONSTANTS = {
            __CONSTANT1: 0,
            __CONSTANT2: 0
        };

        // Some internal functions

        // Validations
        var validators = {
            // Undefined
            checkUndefinedAndThrow: function (value) {
                if (value === undefined) {
                    throw new Error(value + ' is undefined');
                }
            },
            // Integer
            isInteger: function (value) {
                this.checkUndefinedAndThrow(value);
                return typeof value === "number" && value === +value && Math.round(value) === value;
            },
            checkIntegerAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isInteger(value)) {
                    throw new Error(value + ' not a integer!');
                }
            },
            // Positive integer
            isPositiveInteger: function (value) {
                this.checkUndefinedAndThrow(value);
                return typeof value === "number" && value === +value && Math.round(value) === value && value >= 0;
            },
            checkPositiveIntegerAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isPositiveInteger(value)) {
                    throw new Error(value + ' not a positive integer!');
                }
            },
            // Float
            isFloat: function (value) {
                this.checkUndefinedAndThrow(value);
                return typeof value === "number" && value === +value && Math.round(value) !== value;
            },
            checkFloatAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isFloat(value)) {
                    throw new Error(value + ' not a float!');
                }
            },
            // Number
            isNumber: function (value) {
                this.checkUndefinedAndThrow(value);
                return !isNaN(parseFloat(value)) && isFinite(value);
            },
            checkNumberAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isNumber(value)) {
                    throw new Error(value + ' not a number!');
                }
            },
            // String
            isString: function (value) {
                this.checkUndefinedAndThrow(value);
                return (typeof value === 'string' || value instanceof String);
            },
            checkStringAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isString(value)) {
                    throw new Error(value + ' not a string!');
                }
            },
            // Boolean
            isBoolean: function (value) {
                this.checkUndefinedAndThrow(value);
                return typeof value === 'boolean' || value === 'true' || value === 'false';
            },
            checkBooleanAndThrow: function (value) {
                if (!this.isBoolean(value)) {
                    this.checkUndefinedAndThrow(value);
                    throw new Error(value + ' not a boolean!');
                }
            },
            // Array
            isArray: function (value) {
                this.checkUndefinedAndThrow(value);
                return Array.isArray(value);
            },
            checkArrayAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isArray(value)) {
                    throw new Error(value + ' not a array!');
                }
            },
            // Object
            isObject: function (value) {
                this.checkUndefinedAndThrow(value);
                return Object.prototype.toString.call(value) === '[object Object]';
            },
            checkObjectAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isObject(value)) {
                    throw new Error(value + ' not a object!');
                }
            }
        };

        var __parent = (function () {
            // Private functions
            var __parentInternal = Object.create({});

            Object.defineProperties(__parentInternal, {
                'init': {
                    value: function (__params) {
                        //this.param = __params;
                        return this;
                    }
                },
                'param': {
                    get: function () {
                        return this._param;
                    },
                    set: function (value) {
                        // validators.............
                        this._param = value;
                    }
                },
                'func': {
                    value: function () {
                        // some function
                    }
                }
            });
            return __parentInternal;
        }());

        var __child = (function (parent) {
            var __childInternal = Object.create(parent);

            Object.defineProperties(__childInternal, {
                'init': {
                    value: function (__params) {
                        //this.param = __params;
                        return this;
                    }
                },
                'param': {
                    get: function () {
                        return this._param;
                    },
                    set: function (value) {
                        // validators.............
                        this._param = value;
                    }
                },
                'func': {
                    value: function () {
                        // some function
                    }
                }
            });
            return __childInternal;
        }(__parent));

        return {
            someFunc1: function (name) {
                return Object.create(__child).init('param');
            },
            someFunc2: function (name) {
                return Object.create(__parent).init('param');
            }
        };

    })();
    return module;
}
