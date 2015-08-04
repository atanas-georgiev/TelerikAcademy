$.fn.tabs = function () {
    var $this = $(this);
    $this.addClass("tabs-container");
    var $items = $this.find(".tab-item");
    $items.children(".tab-item-content").hide();

    $items.first().addClass("current");
    $items.first().children(".tab-item-content").show();

    $items.on("click", ".tab-item-title", function (ev) {
        var $element = $(ev.target);
        $items.removeClass("current");
        $items.children(".tab-item-content").hide();
        $element.parent().addClass("current");
        $element.parent().children(".tab-item-content").show();
    });

};
