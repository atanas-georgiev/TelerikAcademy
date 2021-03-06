﻿(function () {
    'use strict';

    function MainController($location, auth, identity) {
        var vm = this;
        // this is for initial load of the page
        waitForLogin();

        vm.logout = function () {
            vm.globallySetCurrentUser = undefined;
            auth.logout();
            waitForLogin(); // this is for second login
            $location.path('/');
        };

        function waitForLogin() {            
            auth.getIdentity()
                .then(function (user) {
                    vm.globallySetCurrentUser = user;
                });
        }
    }

    angular.module('ticTacToeApp')
        .controller('MainController', ['$location', 'auth', 'identity', MainController]);
}());