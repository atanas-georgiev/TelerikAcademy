function solve() {
    return function () {
        $.fn.listview = function (data) {
            var $this = $(this),
                postTempate = handlebars.compile($('#' + $this.attr('data-template')).html()),
                result = '';

            data.forEach(function(value) {
                result += postTempate(value);
            });

            $this.html(result);
        };
    };
}

module.exports = solve;
