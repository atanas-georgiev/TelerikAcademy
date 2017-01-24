var cookieController = (function() {

    function add(context) {
        templates.get('cookies-add')
            .then(function(template) {
                $('.dropdown.open .dropdown-toggle').dropdown('toggle');
                context.$element().html(template());
                events.registerCookieAddEvent(context);
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    function listAll(context) {
        $('.dropdown.open .dropdown-toggle').dropdown('toggle');
        context.redirect('#/home');
    }

    function GetFortune(context) {
        var cookiesToDisplay,
            currentUser,
            cookieToDisplay;

        dataFortuneCookies.getAll()
            .then(function(cookies) {
                cookiesToDisplay = cookies;
                return dataUsers.getCurrentLogin();
            }, function(err) {
                $.notify(err.responseText, "error");
            })
            .then(function(user) {
                currentUser = user;
                return dataFortuneCookies.GetFortuneCookie(currentUser);
            }, function(err) {
                $.notify(err.responseText, "error");
            })
            .then(function(data) {
                cookieToDisplay = data;
                return templates.get('cookie-fortune');
            }, function(err) {
                $.notify(err.responseText, "error");
            })
            .then(function(template) {
                $('.dropdown.open .dropdown-toggle').dropdown('toggle');
                context.$element().html(template(cookieToDisplay));
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    return {
        add: add,
        listAll: listAll,
        GetFortune: GetFortune
    };

}());
