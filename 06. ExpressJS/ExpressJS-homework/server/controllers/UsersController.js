var encryption = require('../utilities/encryption');
var users = require('../data/users');

var CONTROLLER_NAME = 'users';

module.exports = {
    getRegister: function(req, res, next) {
        res.render(CONTROLLER_NAME + '/register', { req: req })
    },
    postRegister: function(req, res, next) {
        var newUserData = req.body;        
        
        if (newUserData.password != newUserData.confirmPassword) {
            req.toastr.error('Passwords do not match!');            
            res.render(CONTROLLER_NAME + '/register', { req: req });
        }
        else {
            newUserData.salt = encryption.generateSalt();
            newUserData.hashPass = encryption.generateHashedPassword(newUserData.salt, newUserData.password);
            users.create(newUserData, function(err, user) {
                if (err) {
                    req.toastr.error('User already exist!');
                    res.render(CONTROLLER_NAME + '/register', { req: req });
                    return;
                }

                req.logIn(user, function(err) {
                    if (err) {
                        req.toastr.error('Cannot login new user!');
                        res.render(CONTROLLER_NAME + '/', { req: req });
                        return;
                    } else {
                        req.toastr.success('User logged in!');
                        res.render('index', { req: req });
                    }
                });
            });
        }
    },
    getLogin: function(req, res, next) {
        res.render(CONTROLLER_NAME + '/login', { req: req });
    }
};