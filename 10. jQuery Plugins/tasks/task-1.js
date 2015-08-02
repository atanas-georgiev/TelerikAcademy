function solve() {



    return function(selector) {

        var $this = $(selector),
            $val1,
            $val2;

        $this = $('<div />').addClass('dropdown-list').append($this);
        $this.children().first().hide();

        $val1 = $('<div />').addClass('current').attr('data-value', '').
        text($this.children().first().children().first().text());

        $val2 = $('<div />').addClass('options-container').hide().css('position', 'absolute');

        for (var i = 0; i < $this.children().first().children().length; i++) {
            var el = $('<div />').addClass('dropdown-item').attr('data-value', 'value-' + (i + 1)).attr('data-index', i).text($this.children().first().children()[i].innerHTML);
            $val2.append(el);
        }

        $this.append($val1);
        $this.append($val2);
        $('body').append($this);

        $('.current').on('click', function() {
            $('.options-container').toggle();
        });

        $('.dropdown-item').on('click', function() {
            $('.current').attr('data-value', $(this).attr('data-value'));
            $('.current').text($(this).text());
            $('.options-container').toggle();
        });
        return this;
    };

}

module.exports = solve;
