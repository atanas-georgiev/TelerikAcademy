(function () {
    'use strict';

    function NewGameController($location, data) {
        var vm = this;        

        vm.newGame = function() {
            data.post('games/create')
                .then(function (id) {
                    $location.path('/game/' + id);
                    }, function() {
                        $location.path('/');
                    }
                );
        }

        vm.newGame();
    };

    angular.module('ticTacToeApp.controllers')
        .controller('NewGameController', ['$location', 'data', NewGameController]);
}());