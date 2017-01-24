var dataFortuneCookies = (function() {

    var fortuneCookies = [];

    function getAll() {
        return jsonRequester.get('api/cookies', {})
            .then(function(res) {
                return res.result;
            });
    }

    function Like(context, id) {
        var contextLocal = context;
        return jsonRequester.put('api/cookies/' + id, {
                data: {
                    type: 'like'
                },
                headers: {
                    "x-auth-key": dataUsers.getAuthKeyFromLocalStorage()
                }
            })
            .then(function(resp) {
                contextLocal.redirect('#/');
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    function Dislike(context, id) {
        var contextLocal = context;
        return jsonRequester.put('api/cookies/' + id, {
                data: {
                    type: 'dislike'
                },
                headers: {
                    "x-auth-key": dataUsers.getAuthKeyFromLocalStorage()
                }
            })
            .then(function(resp) {
                contextLocal.redirect('#/');
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    function Add(context, text, category, img) {
        var contextLocal = context;
        return jsonRequester.post('api/cookies', {
                data: {
                    img: img,
                    text: text,
                    category: category
                },
                headers: {
                    "x-auth-key": dataUsers.getAuthKeyFromLocalStorage()
                }
            })
            .then(function(resp) {
                $.notify("Cookie added", "success");
                contextLocal.redirect('#/');
            }, function(err) {
                $.notify(err.responseText, "error");
            });
    }

    function getCategories() {
        return jsonRequester.get('api/categories', {})
            .then(function(res) {
                return res.result;
            });
    }

    function GetFortuneCookie(user) {
        return jsonRequester.get('api/cookies', {})
            .then(function(res) {
                var found = false;

                fortuneCookies.forEach(function(obj) {
                    if (obj.username === user) {
                        var diff = Date.now() - obj.dateTime;
                        if (diff < 3600 * 3600) {
                            return obj.cookie;
                        }
                    }
                });

                if (!found) {
                    var cookie = res.result[Math.floor(Math.random() * res.result.length)];
                    fortuneCookies.push({
                        username: user,
                        dateTime: Date.now(),
                        cookie: cookie
                    });
                    return cookie;
                }
            });
    }

    return {
        getAll: getAll,
        Add: Add,
        getCategories: getCategories,
        Like: Like,
        Dislike: Dislike,
        GetFortuneCookie: GetFortuneCookie
    };
}());
