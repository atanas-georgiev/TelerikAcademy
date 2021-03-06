﻿(function () {
    'use strict';

    var authService = function authService($http, $q, $cookies, identity, baseUrl) {
        var TOKEN_KEY = 'authentication'; // cookie key
        var USERNAME = 'user'; // username

        var register = function register(user) {
            var defered = $q.defer();

            $http.post(baseUrl + 'api/account/register', user)
                .then(function () {
                    defered.resolve(true);
                }, function (err) {
                    defered.reject(err);
                });
            l
            return defered.promise;
        }

        var login = function login(user) {
            var deferred = $q.defer();

            // process data with url encoded format because API expects it this way
            var data = "grant_type=password&username=" + (user.username || '') + '&password=' + (user.password || '');

            // set header in order to prevent Angular making data to JSON
            $http.post(baseUrl + 'Token', data, { headers: { 'Content-Type': 'application/x-www-form-urlencoded' } })
                .success(function (response) {
                    var tokenValue = response.access_token; // token for authorized access

                    // cookie expiration date (set it to whatever you want)
                    var theBigDay = new Date();
                    theBigDay.setHours(theBigDay.getHours() + 72);

                    // save cookie for refresh scenarios
                    $cookies.put(TOKEN_KEY, tokenValue, { expires: theBigDay });
                    $cookies.put(USERNAME, JSON.stringify(user.username));

                    // set default Authorization header so that we do not need to provide the header with every request
                    $http.defaults.headers.common.Authorization = 'Bearer ' + tokenValue;

                    getIdentity().then(function () {
                        deferred.resolve(response);
                    });
                })
                .error(function (err) {
                    deferred.reject(err);
                });

            return deferred.promise;
        };

        var getIdentity = function () {
            var deferred = $q.defer();

            var user = $cookies.get(USERNAME);

            if (user != undefined) {
                console.log(user);
                deferred.resolve(user);
            } 

            //$http.get(baseUrl + '/api/account/identity')
            //    .success(function (identityResponse) {
            //        identity.setUser(identityResponse);
            //        deferred.resolve(identityResponse);
            //    });

            return deferred.promise;
        };

        return {
            register: register,
            login: login,
            getIdentity: getIdentity,
            isAuthenticated: function () {
                return !!$cookies.get(TOKEN_KEY);
            },
            logout: function () {
                $cookies.remove(TOKEN_KEY);
                $cookies.remove(USERNAME);
                $http.defaults.headers.common.Authorization = null;
                identity.removeUser();
            },
        };
    };

    angular
        .module('ticTacToeApp.services')
        .factory('auth', ['$http', '$q', '$cookies', 'identity', 'baseUrl', authService]);
}());