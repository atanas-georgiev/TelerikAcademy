(function () {
    'use strict';

    function JoinGameController($location, data) {
        var vm = this;

        vm.message = "";

        vm.JoinGame = function () {            
            data.post('games/join')
                .then(function (id) {
                    $location.path('/game/' + id);
                    }, function(error) {
                        vm.message = "Error: " + JSON.stringify(error);
                    }
                );
        }

        vm.JoinGame();
    };

    angular.module('ticTacToeApp.controllers')
        .controller('JoinGameController', ['$location', 'data', JoinGameController]);
}());