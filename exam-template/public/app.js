(function () {
    var sammyApp = Sammy('#content', function () {
        var $content = $('#content');

        // var todosController = todosControllerFactory.get($content),
        //     eventsController = eventsControllerFactory.get($content);

        this.get('#/', function (context) {
            context.redirect('#/home');
        });

        this.get('#/home', function (context) {
            templates.get('home')
                .then(function (template) {
                    $content.html(template());
                    return dataUser.getCurrentUser();
                })
                .then(function (user) {
                    if (user) {
                        $('#container-sign-in').hide();
                        $('#container-sign-out').show();
                        $('#btn-logout').html("Logout [" + user + "]");
                        $('#btn-logout').on('click', function () {
                            dataUser.logout()
                                .then(function () {
                                    context.redirect('#/');
                                }, function (err) {
                                    dataMessage.error(err.responseText);
                                });
                        });
                    } else {
                        $('#container-sign-in').show();
                        $('#container-sign-out').hide();
                        $('#btn-login').on('click', function () {
                            var user = {
                                username: $('#tb-username').val(),
                                password: $('#tb-password').val()
                            };
                            $('.dropdown.open .dropdown-toggle').dropdown('toggle');
                            dataUser.login(user)
                                .then(function (user) {
                                    context.redirect('#/');
                                }, function (err) {
                                    dataMessage.error(err.responseText);
                                });
                        });
                        $('#btn-register').on('click', function () {
                            var user = {
                                username: $('#tb-username').val(),
                                password: $('#tb-password').val()
                            };
                            $('.dropdown.open .dropdown-toggle').dropdown('toggle');
                            dataUser.register(user)
                                .then(function (user) {
                                    context.redirect('#/');
                                }, function (err) {
                                    dataMessage.error(err.responseText);
                                });
                        });
                    }
                });
        });

        this.get('#/users', function (context) {
            var usersToDisplay;
            dataUser.getAllUsersPages(3, 0)
                .then(function (users) {
                    usersToDisplay = users;
                    console.log(users.data);
                    return templates.get('users');
                }, function (err) {
                    dataMessage.error(err.responseText);
                })
                .then(function (template) {
                    $content.html(template(usersToDisplay));
                }, function (err) {
                    dataMessage.error(err.responseText);
                });
        });

        this.get('#/users/:size/:page', function (context) {
            var usersToDisplay;
            console.log(this.params.size);
            console.log(this.params.page);
            dataUser.getAllUsersPages(this.params.size, this.params.page - 1)
                .then(function (users) {
                    usersToDisplay = users;
                    console.log(users);
                    return templates.get('users');
                }, function (err) {
                    dataMessage.error(err.responseText);
                })
                .then(function (template) {
                    $content.html(template(usersToDisplay));
                }, function (err) {
                    dataMessage.error(err.responseText);
                });
        });
        //
        // this.get('#/todos', todosController.all);
        // this.get('#/todos/add', todosController.add);
        //
        // this.get('#/events', eventsController.all);
        // this.get('#/events/add', eventsController.add);
    });

    $(function () {
        sammyApp.run('#/');
    });
}());
