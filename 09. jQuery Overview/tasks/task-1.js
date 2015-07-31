/* globals $ */
/* Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:
 * The UL must have a class `items-list`
 * Each of the LIs must:
 * have a class `list-item`
 * content "List item #INDEX"
 * The indices are zero-based
 * If the provided selector does not selects anything, do nothing
 * Throws if
 * COUNT is a `Number`, but is less than 1
 * COUNT is **missing**, or **not convertible** to `Number`
 * _Example:_
 * Valid COUNT values:
 * 1, 2, 3, '1', '4', '1123'
 * Invalid COUNT values:
 * '123px' 'John', {}, []
 */

function solve() {

    function isNumber(value) {
        return !isNaN(parseFloat(value)) && isFinite(value);
    }

    function isString(value) {
        return (typeof value === 'string' || value instanceof String);
    }

    return function (selector, count) {
        if (count === undefined) {
            throw new Error('count is undefined!');
        }

        if (!isNumber(count)) {
            throw new Error('count is not a number!');
        }

        if (count < 1) {
            throw new Error('count is less than 1!');
        }

        if (selector === undefined) {
            throw new Error('selector is undefined!');
        }

        if (!isString(selector)) {
            throw new Error('selector is not a string!');
        }

        var element = $(selector);

        if (element.length !== 0) {
            var ul = $('<ul/>').addClass('items-list');
            for (var i = 0; i < count; i += 1) {
                var li = $('<li/>').addClass('list-item').text('List item #' + i);
                ul.append(li);
            }
            element.append(ul);
        }
    };
}

module.exports = solve;
