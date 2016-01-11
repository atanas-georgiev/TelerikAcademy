var UsersController = require('./UsersController');
var AdsController = require('./AdsController');
var IndexController = require('./IndexController');
 
module.exports = {
	users: UsersController,
    ads: AdsController,
    index: IndexController
};