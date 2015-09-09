var events = (function () {

    function _getUserDetails() {
        var user = {
            username: $('#tb-username').val(),
            password: $('#tb-password').val()
        };
        return user;
    }

    function registerLoginEvent(context) {
        $("#btn-login").unbind('click');
        $('#btn-login').on('click', function () {
            $('.dropdown.open .dropdown-toggle').dropdown('toggle');
            dataUser.login(_getUserDetails())
                .then(function (user) {
                    $.notify("User " + user.username + " logged in!", "success");
                    context.redirect('#/');
                }, function (err) {
                    $.notify(err.responseText, "error");
                });
        });
    }

    function registerRegEvent(context) {
        $("#btn-register").unbind('click');
        $('#btn-register').on('click', function () {
            $('.dropdown.open .dropdown-toggle').dropdown('toggle');
            dataUser.register(_getUserDetails())
                .then(function (user) {
                    $.notify("User " + user.username + " registered and logged in!", "success");
                    context.redirect('#/');
                }, function (err) {
                    $.notify(err.responseText, "error");
                });
        });
    }

    function registerLogoutEvent(context) {
        $("#btn-logout").unbind('click');
        $('#btn-logout').on('click', function () {
            dataUser.logout()
                .then(function () {
                    $.notify("User successfully logged out!", "success");
                    context.redirect('#/');
                }, function (err) {
                    $.notify(err.responseText, "error");
                });
        });
    }

    return {
        registerLoginEvent: registerLoginEvent,
        registerRegEvent: registerRegEvent,
        registerLogoutEvent: registerLogoutEvent
    };

}());
