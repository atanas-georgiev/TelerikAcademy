var passport = require('passport');
var CONTROLLER_NAME = 'users';

module.exports = {
	login: function (req, res, next) {
		var auth = passport.authenticate('local', function (err, user) {
			if (err) return next(err);
			if (!user) {
                req.toastr.error('Username and/or password is not correct!');
                res.render(CONTROLLER_NAME + '/login', { req: req });
			}
			
			req.logIn(user, function (err) {
                if (err) return next(err);
                req.toastr.success('User logged in!');
                res.render('index', { req: req });
			});
		});
		
		auth(req, res, next);
	},
	logout: function (req, res, next) {
        req.logout();
        req.toastr.success('User logged out!');
        res.render('index', { req: req });
	},
	isAuthenticated: function (req, res, next) {
		if (!req.isAuthenticated()) {
            req.toastr.error('Not autorized, please login');
            res.render('unautorized', { req: req });
		}
		else {
			next();
		}
    }
};