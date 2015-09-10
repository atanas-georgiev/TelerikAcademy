var homeController = (function() {

    function _getCookieCategories(cookies) {
        var res = [];
        cookies.forEach(function(obj) {
            if (res.indexOf(obj.category) < 0) {
                res.push(obj.category);
            }
        });
        return res;
    }

    function _getUserNameById(users, id) {
        var res = '';
        users.forEach(function(obj) {
            if (obj.id === id) {
                res = obj.username;
            }
        });
        return res;
    }

    function displayHomePage(context) {
        var cookiesToDisplay,
            currentUser,
            allUsers,
            category = this.params.category || null;

        dataFortuneCookies.getAll()
            .then(function(cookies) {
                cookiesToDisplay = cookies;
                return dataUsers.getAll(Number.MAX_VALUE, 1);
            }, function(err) {
                $.notify(err.responseText, "error");
            })
            .then(function(users) {
                allUsers = users;
                return dataUsers.getCurrentLogin();
            }, function(err) {
            //    $.notify(err.responseText, "error");
            })
            .then(function(user) {
                currentUser = user;
                if (user) {
                    // User is logged in
                    $('#container-sign-in').hide();
                    $('#container-sign-out').show();
                    $('.admin-data-hidden').show();
                    $('#btn-logout').html("Logout [" + user + "]");
                    events.registerLogoutEvent(context);
                } else {
                    // User is not logged in
                    $('#container-sign-in').show();
                    $('#container-sign-out').hide();
                    $('.admin-data-hidden').hide();
                    events.registerLoginEvent(context);
                    events.registerRegEvent(context);
                }
                return templates.get('home');
            })
            .then(function(template) {
                // Change date format with MomentJS
                cookiesToDisplay.forEach(function(obj) {
                    obj.shareDate = moment(obj.shareDate).fromNow();
                    if (allUsers) {
                        obj.postedBy = _getUserNameById(allUsers.data, obj.userId);
                    }
                });

                if (category) {
                    var filtered = cookiesToDisplay.filter(function(obj) {
                        if (obj.category === category) {
                            return true;
                        }
                        return false;
                    });

                    context.$element().html(template({
                        user: currentUser,
                        data: filtered,
                        category: category,
                        categories: _getCookieCategories(cookiesToDisplay)
                    }));
                } else {
                    context.$element().html(template({
                        user: currentUser,
                        data: cookiesToDisplay,
                        category: 'All',
                        categories: _getCookieCategories(cookiesToDisplay)
                    }));
                }

                events.registerLikeEvent(context);
                events.registerDislikeEvent(context);
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    return {
        displayHomePage: displayHomePage
    };
}());
