var User = require('mongoose').model('User');

module.exports = {
    create: function(user, callback) {
        User.create(user, callback);
    },
    getByUsername: function (username, callback) {
        Ad.findOne()
	        .where('username').equals(username)
	        .exec(function (err, ad) {
            callback(err, ad);
        });
    }, 
};