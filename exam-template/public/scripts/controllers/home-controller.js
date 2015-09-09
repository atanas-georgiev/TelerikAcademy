var homeController = (function () {

    function displayHomePage(context) {
        templates.get('home')
            .then(function (template) {
                context.$element().html(template());
                return dataUsers.getCurrentLogin();
            })
            .then(function (user) {
                if (user) {
                    // User is logged in
                    $('#container-sign-in').hide();
                    $('#container-sign-out').show();
                    $('#btn-logout').html("Logout [" + user + "]");
                    events.registerLogoutEvent(context);
                } else {
                    // User is not logged in
                    $('#container-sign-in').show();
                    $('#container-sign-out').hide();
                    events.registerLoginEvent(context);
                    events.registerRegEvent(context);
                }
            });
    }

    return {
        displayHomePage: displayHomePage
    };
}());
