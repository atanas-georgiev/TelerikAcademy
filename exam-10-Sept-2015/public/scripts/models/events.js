var events = (function() {

    function _getUserDetails() {
        var user = {
            username: $('#tb-username').val(),
            password: $('#tb-password').val()
        };
        return user;
    }

    function _updateLikes() {
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
            if ($('#tb-username').val().length < 6 || $('#tb-username').val().length > 30) {
                $.notify("Invalid username", "error");
            } else {
                usersController.login(context, _getUserDetails());
            }
        });
    }

    function registerRegEvent(context) {
        $("#btn-register").unbind('click');
        $('#btn-register').on('click', function() {
            if ($('#tb-username').val().length < 6 || $('#tb-username').val().length > 30) {
                $.notify("Invalid username", "error");
            } else {
                $('.dropdown.open .dropdown-toggle').dropdown('toggle');
                usersController.registerAndLogin(context, _getUserDetails());
            }
        });
    }

    function registerLogoutEvent(context) {
        $("#btn-logout").unbind('click');
        $('#btn-logout').on('click', function() {
            usersController.logout(context);
        });
    }

    function registerLikeEvent(context) {
        $("#cookies-table").unbind('click', '#img-like-details');
        $('#cookies-table').on('click', '#img-like-details', function() {
            var id = $(this).parent().children(":last").text();
            dataFortuneCookies.Like(context, id);
        });
    }

    function registerDislikeEvent(context) {
        $("#cookies-table").unbind('click', '#img-dislike-details');
        $('#cookies-table').on('click', '#img-dislike-details', function() {
            var id = $(this).parent().children(":last").text();
            dataFortuneCookies.Dislike(context, id);
        });
    }

    function registerCookieAddEvent(context) {
        $("#cookies-add-btn").unbind('click');
        $('#cookies-add-btn').on('click', function() {
            if ($("#cookies-add-image").val() === "") {
                $("#cookies-add-image").val('https://dayinthelifeofapurpleminion.files.wordpress.com/2014/12/batman-exam.jpg');
            }

            if ($('#cookies-add-text').val().length < 6 || $('#cookies-add-text').val().length > 30) {
                $.notify("Invalid text", "error");
            } else if ($('#cookies-add-category').val().length < 6 || $('#cookies-add-category').val().length > 30) {
                $.notify("Invalid category", "error");
            } else {
                dataFortuneCookies.Add(
                    context,
                    $("#cookies-add-text").val(),
                    $("#cookies-add-category").val(),
                    $("#cookies-add-image").val()
                );
            }
        });
    }

    return {
        registerLoginEvent: registerLoginEvent,
        registerRegEvent: registerRegEvent,
        registerLogoutEvent: registerLogoutEvent,
        registerLikeEvent: registerLikeEvent,
        registerDislikeEvent: registerDislikeEvent,
        registerCookieAddEvent: registerCookieAddEvent
    };

}());
