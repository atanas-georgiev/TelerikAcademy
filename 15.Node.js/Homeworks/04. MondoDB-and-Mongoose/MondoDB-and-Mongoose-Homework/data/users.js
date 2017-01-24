var User = require('mongoose').model('User');

module.exports = {
    create: function (user, callback) {
        User.findOne()
	        .where('username').equals(user.username)
	        .exec(function (err, user) {
            if (user == null) {
                // set error flag if user exist
                err = true;
                callback(true);
            }                       
        });

        User.create(user, callback);
    },
    get: function (username, callback) {        
        User.findOne()
	        .where('username').equals(username)
	        .exec(function (err, user) {
            if (user == null) {
                // set error flag if user do not exist
                err = true;
            }

            callback(err, user);
        });
    }
};