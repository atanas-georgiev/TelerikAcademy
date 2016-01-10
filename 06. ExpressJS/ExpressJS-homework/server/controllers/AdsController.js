var ads = require('../data/ads');

var CONTROLLER_NAME = 'ads';

module.exports = {
    getAdd: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/add')
    },
    postAdd: function (req, res, next) {
        var newAd = req.body;
        console.log(newAd);
        //newAd.salt = encryption.generateSalt();
        //newAd.hashPass = encryption.generateHashedPassword(newUserData.salt, newUserData.password);
        //users.create(newUserData, function (err, user) {
        //    if (err) {
        //        console.log('Failed to register new user: ' + err);
        //        return;
        //    }

        //    req.logIn(user, function (err) {
        //        if (err) {
        //            res.status(400);
        //            return res.send({ reason: err.toString() }); // TODO
        //        }
        //        else {
        //            res.redirect('/');
        //        }
        //    })
        //});
    }
};