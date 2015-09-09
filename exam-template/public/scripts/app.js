(function () {
    var sammyApp = Sammy('#content', function () {

        this.get('#/', function (context) {
            context.redirect('#/home');
        });

        this.get('#/home', homeController.displayHomePage);

        this.get('#/users', usersController.getUsers);

    });

    $(function () {
        // Application entry point
        sammyApp.run('#/');
    });
}());
