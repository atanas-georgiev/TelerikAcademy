function solve() {
    'use strict';

    var module = (function () {

        // Constants in the module
        var validators,
            item,
            book,
            media,
            catalog,
            bookcatalog,
            mediacatalog;

        // Some internal functions

        // Validations
        validators = {
            // Undefined
            checkUndefinedAndThrow: function (value) {
                if (value === undefined) {
                    throw new Error(value + ' is undefined');
                }
            },
            // isInteger
            isInteger: function (value) {
                this.checkUndefinedAndThrow(value);
                return Number(value) === value && value % 1 === 0;
            },
            checkIntegerAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isInteger(value)) {
                    throw new Error(value + ' not a integer!');
                }
            },
            // Positive integer
            isPositiveInteger: function (value) {
                return this.isInteger(value) && value > 0;
            },
            checkPositiveIntegerAndThrow: function (value) {
                this.checkUndefinedAndThrow(value);
                if (!this.isPositiveInteger(value)) {
                    throw new Error(value + ' not a positive integer!');
                }
            },
            //Float
            isFloat: function (value) {
                this.checkUndefinedAndThrow(value);
                return Number(value) === value && value % 1 !== 0;
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
            },
            // others
            getById: function (collection, id) {
                if (collection === undefined || id === undefined) {
                    throw new Error();
                }

                var i, len;
                for (i = 0, len = collection.length; i < len; i++) {
                    if (collection[i].id === id) {
                        return collection[i];
                    }
                }

                return null;
            },
            getAllByName: function (collection, name) {
                var result = [];
                if (collection === undefined || name === undefined) {
                    throw new Error();
                }

                var i, len;
                for (i = 0, len = collection.length; i < len; i++) {
                    if (collection[i].name.toUpperCase() === name.toUpperCase()) {
                        result.push(collection[i]);
                    }
                }

                if (result.length === 0) {
                    return null;
                } else {
                    return result;
                }
            },
            getAllByObject: function (collection, obj) {
                var result = [];
                if (obj === undefined) {
                    throw new Error();
                }

                var vals = Object.keys(obj);

                var i, len, j;

                for (i = 0, len = collection.length; i < len; i++) {
                    var found = 0;
                    for (j = 0; j < vals.length; j++) {
                        if (this.isString(collection[i][vals[j]])) {
                            if (collection[i][vals[j]].toUpperCase() === obj[vals[j]].toUpperCase()) {
                                found++;
                            }
                        } else {
                            if (collection[i][vals[j]] === obj[vals[j]]) {
                                found++;
                            }
                        }
                        // console.log(collection[i][vals[j]]);
                        // console.log(obj[vals[j]]);
                    }

                    if (found === vals.length) {

                        result.push(collection[i]);
                    }
                }
                if (result.length === 0) {
                    return null;
                } else {
                    return result.slice();
                }
            },
            getIndexById: function (collection, id) {
                if (collection === undefined || id === undefined) {
                    throw new Error();
                }

                var i, len;
                for (i = 0, len = collection.length; i < len; i++) {
                    if (collection[i].id === id) {
                        return i;
                    }
                }

                return null;
            },
            getByNameAndId: function (collection, id, name) {
                if (collection === undefined || id === undefined || name === undefined) {
                    throw new Error();
                }

                var i, len;
                for (i = 0, len = collection.length; i < len; i++) {
                    if (collection[i].name.toUpperCase() === name.toUpperCase() && collection[i].id === id) {
                        return collection[i];
                    }
                }

                return null;
            },
            checkRange: function (value, minLen, maxLen) {
                this.checkUndefinedAndThrow(value);
                this.checkNumberAndThrow(minLen);
                this.checkNumberAndThrow(maxLen);
                if (value.length < minLen || value.length > maxLen) {
                    throw new Error(value + ' must be between ' + minLen + ' and ' + maxLen);
                }
            }
        };

        item = (function () {
            // Private functions
            var itemInternal = Object.create({}),
                numberId = 0;

            Object.defineProperties(itemInternal, {
                init: {
                    value: function (name, description) {
                        this._id = ++numberId;
                        this.name = name;
                        this.description = description;
                        return this;
                    }
                },
                id: {
                    get: function () {
                        return this._id;
                    }
                },
                name: {
                    get: function () {
                        return this._name;
                    },
                    set: function (value) {
                        validators.checkStringAndThrow(value);
                        validators.checkRange(value, 2, 40);
                        this._name = value;
                    }
                },
                description: {
                    get: function () {
                        return this._description;
                    },
                    set: function (value) {
                        validators.checkStringAndThrow(value);
                        validators.checkRange(value, 1, Number.MAX_VALUE);
                        this._description = value;
                    }
                }
            });
            return itemInternal;
        }());

        book = (function (parent) {
            var bookInternal = Object.create(parent);

            Object.defineProperties(bookInternal, {
                init: {
                    value: function (name, description, isbn, genre) {
                        parent.init.call(this, name, description);
                        this.isbn = isbn;
                        this.genre = genre;
                        return this;
                    }
                },
                isbn: {
                    get: function () {
                        return this._isbn;
                    },
                    set: function (value) {
                        validators.checkRange(value, 10, 13);
                        if (/^\d+$/.test(value) === false) {
                            throw new Error('isbn do not contain only digits!');
                        }
                        this._isbn = value;
                    }
                },
                genre: {
                    get: function () {
                        return this._genre;
                    },
                    set: function (value) {
                        validators.checkStringAndThrow(value);
                        validators.checkRange(value, 2, 20);
                        this._genre = value;
                    }
                }
            });
            return bookInternal;
        }(item));

        media = (function (parent) {
            var mediaInternal = Object.create(parent);

            Object.defineProperties(mediaInternal, {
                init: {
                    value: function (name, description, duration, rating) {
                        parent.init.call(this, name, description);
                        this.duration = duration;
                        this.rating = rating;
                        return this;
                    }
                },
                duration: {
                    get: function () {
                        return this._duration;
                    },
                    set: function (value) {
                        validators.checkNumberAndThrow(value);
                        if (value <= 0) {
                            throw new Error('duration must be > 0!');
                        }
                        this._duration = value;
                    }
                },
                rating: {
                    get: function () {
                        return this._rating;
                    },
                    set: function (value) {
                        validators.checkNumberAndThrow(value);
                        if (value < 1 || value > 5) {
                            throw new Error('rating must be between 1 and 5!');
                        }
                        this._rating = value;
                    }
                }
            });
            return mediaInternal;
        }(item));

        catalog = (function () {
            var catalogInternal = Object.create({}),
                catalogId = 0;

            Object.defineProperties(catalogInternal, {
                init: {
                    value: function (name) {
                        this._id = ++catalogId;
                        this.name = name;
                        this.items = [];
                        return this;
                    }
                },
                id: {
                    get: function () {
                        return this._id;
                    }
                },
                name: {
                    get: function () {
                        return this._name;
                    },
                    set: function (value) {
                        validators.checkStringAndThrow(value);
                        validators.checkRange(value, 2, 40);
                        this._name = value;
                    }
                },
                items: {
                    get: function () {
                        return this._items;
                    },
                    set: function (value) {
                        var i,
                            len;
                        validators.checkArrayAndThrow(value);
                        len = value.length;
                        for (i = 0; i < len; i++) {
                            validators.checkUndefinedAndThrow(value.id);
                        }
                        this._items = value;
                    }
                },
                add: {
                    value: function (items) {
                        var i,
                            len,
                            tempArr = [];
                        validators.checkUndefinedAndThrow(items);
                        if (validators.isArray(items)) {
                            if (items.length === 0) {
                                throw new Error('Array is empty!');
                            }
                            len = items.length;
                            for (i = 0; i < len; i++) {
                                validators.checkUndefinedAndThrow(items[i]);
                                validators.checkUndefinedAndThrow(items[i].id);
                                validators.checkUndefinedAndThrow(items[i].name);
                                validators.checkUndefinedAndThrow(items[i].description);
                                tempArr.push(items[i]);
                            }
                            Array.prototype.push.apply(this.items, tempArr);
                        } else {
                            len = arguments.length;
                            for (i = 0; i < len; i++) {
                                validators.checkUndefinedAndThrow(arguments[i]);
                                validators.checkUndefinedAndThrow(arguments[i].id);
                                validators.checkUndefinedAndThrow(arguments[i].name);
                                validators.checkUndefinedAndThrow(arguments[i].description);
                                tempArr.push(arguments[i]);
                            }
                            Array.prototype.push.apply(this.items, tempArr);
                        }
                        return this;
                    }
                },
                find: {
                    value: function (items) {
                        var searchResults = [],
                            element,
                            i,
                            len;
                        validators.checkUndefinedAndThrow(items);

                        if (items.length === 0) {
                            throw new Error('Array is empty!');
                        }
                        if (validators.isPositiveInteger(items)) {
                            element = validators.getById(this.items, items);
                            return [{
                                name: element.name,
                                id: element.id
                            }];
                        } else if (validators.isObject(items)) {
                                element = validators.getAllByObject(this.items, items);
                                if (element !== null) {
                                    len = element.length;
                                    for (i = 0; i < len; i++) {
                                        searchResults.push({
                                            name: element[i].name,
                                            id: element[i].id
                                        });
                                    }
                                }
                                return searchResults;

                        } else if (validators.isString(items)) {
                            len = this.items.length;
                            for (i = 0; i < len; i++) {
                                if (this.items[i].name.toLowerCase().indexOf(items.toLowerCase()) > -1 ||
                                    this.items[i].description.toLowerCase().indexOf(items.toLowerCase()) > -1) {
                                    searchResults.push({
                                        name: this.items[i].name,
                                        id: this.items[i].id
                                    });
                                }
                            }
                            return searchResults;
                        } else {
                            throw new Error(items + ' is not correct!');
                        }
                    }
                }
            });
            return catalogInternal;
        }());

        bookcatalog = (function (parent) {
            var bookcatalogInternal = Object.create(parent);

            Object.defineProperties(bookcatalogInternal, {
                init: {
                    value: function (name) {
                        parent.init.call(this, name);
                        return this;
                    }
                },
                add: {
                    value: function (items) {
                        var i,
                            len;
                        validators.checkUndefinedAndThrow(items);

                        if (validators.isArray(items)) {
                            if (items.length === 0) {
                                throw new Error('Array is empty!');
                            }
                            len = items.length;
                            for (i = 0; i < len; i++) {
                                validators.checkUndefinedAndThrow(items[i]);
                                validators.checkUndefinedAndThrow(items[i].isbn);
                                validators.checkUndefinedAndThrow(items[i].genre);
                            }
                            parent.add.call(this, items);
                        } else {
                            len = arguments.length;
                            for (i = 0; i < len; i++) {
                                validators.checkUndefinedAndThrow(arguments[i]);
                                validators.checkUndefinedAndThrow(arguments[i].isbn);
                                validators.checkUndefinedAndThrow(arguments[i].genre);
                            }
                            parent.add.call(this, Array.prototype.slice.call(arguments));
                        }

                        return this;
                    }
                },
                getGenres: {
                    value: function (items) {
                        var result = [],
                            i,
                            j,
                            found,
                            len;

                        len = this.items.length;
                        for (i = 0; i < len; i++) {
                            found = false;
                            for (j = 0; j < result.length; j++) {
                                if (this.items[i].genre.toLowerCase() === result[j].toLowerCase()) { //??????????
                                    found = true;
                                }
                            }
                            if (found === false) {
                                result.push(this.items[i].genre.toLowerCase());
                            }
                        }
                        return result;
                    }
                },
                search: {
                    value: function (items) {
                        //validators.checkObjectAndThrow(items);
                        return parent.find.call(this, items); // todo
                    }
                }
            });
            return bookcatalogInternal;
        }(catalog));

        mediacatalog = (function (parent) {
            var mediacatalogInternal = Object.create(parent);

            Object.defineProperties(mediacatalogInternal, {
                init: {
                    value: function (name) {
                        parent.init.call(this, name);
                        return this;
                    }
                },
                add: {
                    value: function (items) {
                        var i,
                            len;
                        validators.checkUndefinedAndThrow(items);

                        if (validators.isArray(items)) {
                            if (items.length === 0) {
                                throw new Error('Array is empty!');
                            }
                            len = items.length;
                            for (i = 0; i < len; i++) {
                                validators.checkUndefinedAndThrow(items[i]);
                                validators.checkUndefinedAndThrow(items[i].duration);
                                validators.checkUndefinedAndThrow(items[i].rating);
                            }
                            parent.add.call(this, items);
                        } else {
                            len = arguments.length;
                            for (i = 0; i < len; i++) {
                                validators.checkUndefinedAndThrow(arguments[i]);
                                validators.checkUndefinedAndThrow(arguments[i].duration);
                                validators.checkUndefinedAndThrow(arguments[i].rating);
                            }
                            parent.add.call(this, Array.prototype.slice.call(arguments));
                        }
                        return this;
                    }
                },
                getTop: {
                    value: function (count) {
                        var result = [],
                            result2 = [],
                            i,
                            j,
                            found,
                            len;

                        validators.checkPositiveIntegerAndThrow(count);

                        result = this.items.slice();
                        result.sort(function (item1, item2) {
                            return item2.rating - item1.rating;
                        });

                        len = result.length;
                        for (i = 0; i < len; i++) {
                            result2.push({
                                id: result[i].id,
                                name: result[i].name
                            });
                        }

                        return result2.slice(0, count);
                    }
                },
                getSortedByDuration: {
                    value: function () {
                        var result = [],
                            result2 = [],
                            i,
                            j,
                            found,
                            len;

                        result = this.items.slice();


                        return this.items.slice().sort(function (item1, item2) {
                            if (item2.duration - item1.duration > 0) {
                                return 1;
                            } else if (item2.duration - item1.duration < 0) {
                                return -1;
                            } else {
                                return item1.id - item2.id;
                            }
                        });
                    }
                }
            });
            return mediacatalogInternal;
        }(catalog));

        return {
            getBook: function (name, isbn, genre, description) {
                return Object.create(book).init(name, description, isbn, genre);
            },
            getMedia: function (name, rating, duration, description) {
                return Object.create(media).init(name, description, duration, rating);
            },
            getBookCatalog: function (name) {
                return Object.create(bookcatalog).init(name);
            },
            getMediaCatalog: function (name) {
                return Object.create(mediacatalog).init(name);
            }
        };

    })();

    return module;
}


var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');

catalog.add(book1);
catalog.add(book2);

console.log(catalog.find(book1.id));
//returns book1

console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

console.log(catalog.search('js'));
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'));
//returns []
