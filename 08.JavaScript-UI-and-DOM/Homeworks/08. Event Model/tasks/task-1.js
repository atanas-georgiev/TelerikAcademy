/* globals $ */

/*

Create a function that takes an id or DOM element and:

If an id is provided, select the element
Finds all elements with class button or content within the provided element
Change the content of all .button elements with "hide"
When a .button is clicked:
Find the topmost .content element, that is before another .button and:
If the .content is visible:
Hide the .content
Change the content of the .button to "show"
If the .content is hidden:
Show the .content
Change the content of the .button to "hide"
If there isn't a .content element after the clicked .button and before other .button, do nothing
Throws if:
The provided DOM element is non-existant
The id is either not a string or does not select any DOM element

*/

function solve() {
    return function (selector) {
        var element,
            buttons,
            contents,
            i,
            len,
            next;

        if (typeof selector != 'string') {
            throw new Error('not valid input');
        }

        element = document.getElementById(selector);

        if (element === null) {
            throw new Error('no element with that id');
        }

        buttons = document.getElementsByClassName('button');
        contents = document.getElementsByClassName('content');

        function buttonClicked(event) {
            var clickedButton = event.target;
            var nextContent = clickedButton.nextElementSibling;
            while (nextContent && nextContent.className.indexOf('content') < 0) {
                nextContent = nextContent.nextElementSibling;
            }

            var isContentVisible = nextContent.style.display === '';
            if (isContentVisible) {
                nextContent.style.display = 'none';
                clickedButton.innerHTML = 'show';
            } else {
                nextContent.style.display = ''; // <=> display: block;
                clickedButton.innerHTML = 'hide';
            }
        }

        for (i = 0, len = buttons.length; i < len; i += 1) {
            buttons[i].innerHTML = 'hide';
            buttons[i].addEventListener('click', buttonClicked, false);
        }
    };
}

module.exports = solve;
