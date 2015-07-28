/* globals $ */

/*

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed
*/

module.exports = function () {

    return function (element, contents) {
        var selectedElement,
            newDiv,
            fragment,
            len,
            i;

        if (element === undefined || contents === undefined) {
            throw new Error('Invalid input parameters');
        }

        if (typeof element === 'string') {
            selectedElement = document.getElementById(element);
        } else if (element instanceof HTMLElement) {
            selectedElement = element;
        } else {
            throw new Error('Input element is not correct tag or id!');
        }

        if (selectedElement === null) {
            throw new Error('No element with given ID');
        }

        if (contents.some(function (item) {
                return (typeof (item) !== 'string' && typeof (item) !== 'number');
            })) {
            throw '';
        }

        selectedElement.innerHTML = '';

        newDiv = document.createElement('div');
        fragment = document.createDocumentFragment();

        for (i = 0, len = contents.length; i < len; i += 1) {
            divToAdd = newDiv.cloneNode(true);
            divToAdd.innerHTML = contents[i];
            fragment.appendChild(divToAdd);
        }

        selectedElement.appendChild(fragment);
    };
};
