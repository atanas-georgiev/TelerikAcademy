var User = require('mongoose').model('User');

module.exports = {
    create: function(user, callback) {
        User.create(user, callback);
    },
    getByUsername: function (username, callback) {
        User.findOne()
	        .where('username').equals(username)
	        .exec(function (err, user) {
            callback(err, user);
        });
    }, 
    all: function (callback) {
        User.find()
	        .exec(function (err, user) {
            callback(err, user);
        });
    }
};