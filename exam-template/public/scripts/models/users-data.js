var dataUser = (function () {
    const LOCAL_STORAGE_USERNAME_KEY = 'signed-in-user-username',
        LOCAL_STORAGE_AUTHKEY_KEY = 'signed-in-user-auth-key';

    function register(user) {
        var reqUser = {
            username: user.username,
            passHash: CryptoJS.SHA1(user.username + user.password).toString()
        };

        return jsonRequester.post('api/users', {
                data: reqUser
            })
            .then(function (resp) {
                var user = resp.result;
                localStorage.setItem(LOCAL_STORAGE_USERNAME_KEY, user.username);
                localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY, user.authKey);
                return {
                    username: resp.result.username
                };
            });
    }

    function login(user) {
        var reqUser = {
                username: user.username,
                passHash: CryptoJS.SHA1(user.username + user.password).toString()
            },
            options = {
                data: reqUser
            };

        return jsonRequester.put('api/users/auth', options)
            .then(function (resp) {
                var user = resp.result;
                localStorage.setItem(LOCAL_STORAGE_USERNAME_KEY, user.username);
                localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY, user.authKey);
                return user;
            });
    }

    function logout() {
        var promise = new Promise(function (resolve, reject) {
            localStorage.removeItem(LOCAL_STORAGE_USERNAME_KEY);
            localStorage.removeItem(LOCAL_STORAGE_AUTHKEY_KEY);
            resolve();
        });
        return promise;
    }

    function getCurrentUser() {
        var username = localStorage.getItem(LOCAL_STORAGE_USERNAME_KEY),
            promise = new Promise(function (resolve, reject) {
                if (username) {
                    resolve(username);
                    return;
                }
                resolve(null);
            });
        return promise;
    }

    function getAllUsersPages(maxPerPage, currentPage) {
        return jsonRequester.get('api/users')
            .then(function (res) {
                if (res.result.length <= maxPerPage) {
                    return {
                        data: res.result,
                        pages: [1]
                    };
                } else {
                    var pages = [],
                        rem = res.result.length % maxPerPage,
                        numPages = (res.result.length / maxPerPage) | 0;

                    if (rem !== 0) {
                        numPages += 1;
                    }
                    for (var i = 1; i < numPages + 1; i += 1) {
                        pages.push(i);
                    }
                    return {
                        data: res.result.splice((currentPage - 1) * maxPerPage, maxPerPage),
                        pages: pages
                    };
                }
            });
    }

    return {
        register: register,
        login: login,
        logout: logout,
        getCurrentUser: getCurrentUser,
        getAllUsersPages: getAllUsersPages
    };
}());
