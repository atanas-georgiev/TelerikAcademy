var dataUsers = (function() {
    const LOCAL_STORAGE_USERNAME_KEY = 'signed-in-user-username',
        LOCAL_STORAGE_AUTHKEY_KEY = 'signed-in-user-auth-key';

    function _encryptUser(user) {
        var encryptedUser = {
            username: user.username,
            passHash: CryptoJS.SHA1(user.username + user.password).toString()
        };
        return encryptedUser;
    }

    function _storeUserLocalStorage(user) {
        localStorage.setItem(LOCAL_STORAGE_USERNAME_KEY, user.username);
        localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY, user.authKey);
    }

    function _removeUserLocalStorage() {
        localStorage.removeItem(LOCAL_STORAGE_USERNAME_KEY);
        localStorage.removeItem(LOCAL_STORAGE_AUTHKEY_KEY);
    }

    function _getUserFromLocalStorage() {
        var username = localStorage.getItem(LOCAL_STORAGE_USERNAME_KEY);
        if (username) {
            return username;
        }
        return null;
    }

    function registerAndLogin(user) {
        return jsonRequester.post('api/users', {
                data: _encryptUser(user)
            })
            .then(function(resp) {
                _storeUserLocalStorage(resp.result);
                return user;
            });
    }

    function login(user) {
        console.log(user);
        var options = {
            data: _encryptUser(user)
        };

        return jsonRequester.put('api/users/auth', options)
            .then(function(resp) {
                _storeUserLocalStorage(resp.result);
                return user;
            });
    }

    function logout() {
        var promise = new Promise(function(resolve, reject) {
            _removeUserLocalStorage();
            resolve();
        });
        return promise;
    }

    function getCurrentLogin() {
        var username = _getUserFromLocalStorage(),
            promise = new Promise(function(resolve, reject) {
                resolve(username);
            });
        return promise;
    }

    function getAll(maxPerPage, currentPage) {
        return jsonRequester.get('api/users')
            .then(function(res) {
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
        registerAndLogin: registerAndLogin,
        login: login,
        logout: logout,
        getCurrentLogin: getCurrentLogin,
        getAll: getAll
    };
}());
