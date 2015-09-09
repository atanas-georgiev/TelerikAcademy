var usersController = (function() {
    var pageSize = 10;

    function displayUsers(context) {
        var usersToDisplay,
            page = this.params.page || 1;

        dataUsers.getAll(pageSize, page)
            .then(function(users) {
                usersToDisplay = users;
                return templates.get('users');
            }, function(err) {
                $.notify(err.responseText, "error");
            })
            .then(function(template) {
                context.$element().html(template(usersToDisplay));
                $('#user-table').on('click', 'tr', function() {
                    var id = $(this).children(":first").text();
                    context.redirect('#/users/' + id);
                });
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    // function displayUserDetails(context) {
    //     var usersToDisplay,
    //         id = this.params.id || 1;
    //
    //     data.users.getAll(pageSize, page)
    //         .then(function(users) {
    //             usersToDisplay = users;
    //             return templates.get('users');
    //         }, function(err) {
    //             $.notify(err.responseText, "error");
    //         })
    //         .then(function(template) {
    //             context.$element().html(template(usersToDisplay));
    //         }, function(err) {
    //             $.notify(err.responseText, "error");
    //         });
    // }

    function registerAndLogin(context, user) {
        dataUsers.registerAndLogin(user)
            .then(function(res) {
                $.notify("User " + res.username + " registered and logged in!", "success");
                context.redirect('#/');
            }, function(err) {
                $.notify(err.responseText, "error");
            });

    }

    function login(context, user) {
        dataUsers.login(user)
            .then(function(res) {
                $.notify("User " + res.username + " logged in!", "success");
                context.redirect('#/');
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    function logout(context) {
        dataUsers.logout()
            .then(function() {
                $.notify("User successfully logged out!", "success");
                context.redirect('#/');
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    return {
        displayUsers: displayUsers,
        //    displayUserDetails: displayUserDetails,
        registerAndLogin: registerAndLogin,
        login: login,
        logout: logout
    };

}());
