(function () {
    'use strict';

    function GameController($routeParams, data) {
        var vm = this;
        
        vm.gameData = "";
        vm.id = $routeParams.id;


        vm.refresh = function() {
            data.get('games/status', { gameId: vm.id })
                .then(function (info) {
                    vm.gameData = info.Board;
                });
        }

        vm.refresh();

        vm.play = function(x, y) {
            data.post('games/play', { GameId: vm.id, Row: x, Col: y })
                .then(function (info) {
                    refresh();
                },
                function (error) {
                    vm.message = error.data.Message;
                });
        }
    };

    angular.module('ticTacToeApp.controllers')
        .controller('GameController', ['$routeParams', 'data', GameController]);
}());