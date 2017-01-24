(function () {
    'use strict';

    function catsService(data) {

        var CATS_API_URL = 'api/cats';

        function addCat(cat) {
            return data.post(CATS_API_URL, cat);
        }

        function searchCats(request) {
            return data.get(CATS_API_URL, request);
        }

        return {
            addCat: addCat,
            searchCats: searchCats
        }
    }

    angular.module('ticTacToeApp.services')
        .factory('game', ['data', catsService])
}());