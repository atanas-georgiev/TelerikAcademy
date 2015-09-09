(function () {
    var sammyApp = Sammy('#content', function () {

        this.get('#/', function (context) {
            context.redirect('#/home');
        });

        this.get('#/home', homeController.displayHomePage);

        this.get('#/users', usersController.displayUsers);

        // this.get('#/users/:id', usersController.displayUserDetails);

    });

    $(function () {
        // Application entry point
        sammyApp.run('#/');
    });
}());
