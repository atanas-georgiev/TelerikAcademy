var usersController = (function () {
    var pageSize = 4;

    function getUsers(context) {
        var usersToDisplay,
            page = this.params.page || 1;

        dataUser.getAllUsersPages(pageSize, page)
            .then(function (users) {
                usersToDisplay = users;
                return templates.get('users');
            }, function (err) {
                $.notify(err.responseText, "error");
            })
            .then(function (template) {
                context.$element().html(template(usersToDisplay));
            }, function (err) {
                $.notify(err.responseText, "error");
            });
    }

    return {
        getUsers: getUsers
    };

}());
