var events = (function() {

    function _getUserDetails() {
        var user = {
            username: $('#tb-username').val(),
            password: $('#tb-password').val()
        };
        return user;
    }

    function registerLoginEvent(context) {
        $("#btn-login").unbind('click');
        $('#btn-login').on('click', function() {
            $('.dropdown.open .dropdown-toggle').dropdown('toggle');
            usersController.login(context, _getUserDetails());
        });
    }

    function registerRegEvent(context) {
        $("#btn-register").unbind('click');
        $('#btn-register').on('click', function() {
            $('.dropdown.open .dropdown-toggle').dropdown('toggle');
            usersController.registerAndLogin(context, _getUserDetails());
        });
    }

    function registerLogoutEvent(context) {
        $("#btn-logout").unbind('click');
        $('#btn-logout').on('click', function() {
            usersController.logout(context);
        });
    }

    return {
        registerLoginEvent: registerLoginEvent,
        registerRegEvent: registerRegEvent,
        registerLogoutEvent: registerLogoutEvent
    };

}());
