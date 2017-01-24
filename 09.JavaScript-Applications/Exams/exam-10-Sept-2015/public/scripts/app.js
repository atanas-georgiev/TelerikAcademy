(function() {
    var sammyApp = Sammy('#content', function() {

        this.get('#/', function(context) {
            context.redirect('#/home');
        });

        this.get('#/home', homeController.displayHomePage);

        this.get('#/users', usersController.displayUsers);

        this.get('#/cookies', cookieController.listAll);

        this.get('#/cookies/add', cookieController.add);

        this.get('#/cookies/fortune', cookieController.GetFortune);

    });

    $(function() {
        // Application entry point
        sammyApp.run('#/');
    });
}());
