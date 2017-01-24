/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string`

*/
function solve() {
    return function (selector) {
        var element,
            buttons,
            i,
            len;

        if (typeof selector !== 'string' && !(selector instanceof JQuery)) {
            throw new Error('not valid input');
        }

        if ($(selector).size() === 0) {
            throw new Error('no button elements');
        }

        buttons = $('.button');

        for (i = 0, len = buttons.length; i < len; i += 1) {
            $(buttons[i]).text('hide');
            $(buttons[i]).on('click', function () {
                var $clickedButton = $(this),
                    $next = $clickedButton.next();

                while ($next !== null) {
                    if ($next.hasClass('content')) {
                        if ($next.css('display') === 'none') {
                            $next.css('display', '');
                            $clickedButton.text('hide');
                        } else {
                            $next.hide();
                            $clickedButton.text('show');
                        }
                        break;
                    }
                    $next = $next.next();
                }
            });
        }

    };
}

module.exports = solve;
