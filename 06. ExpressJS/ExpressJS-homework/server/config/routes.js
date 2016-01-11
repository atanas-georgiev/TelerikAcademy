var auth = require('./auth'),
    controllers = require('../controllers');

module.exports = function (app) {
	// Users
    app.get('/register', controllers.users.getRegister);
    app.post('/register', controllers.users.postRegister);

    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login);
	app.get('/logout', auth.logout);
	
	// Ads
    app.get('/ads/add', auth.isAuthenticated, controllers.ads.getAdd);
    app.post('/ads/add', auth.isAuthenticated, controllers.ads.postAdd);
    app.get('/ads/list', controllers.ads.getAll);
    app.get('/ads/:id', controllers.ads.getAdDetails);
        
	// Others
    app.get('/', function(req, res) {
        res.render('index', { req: req, currentUser: req.user});
    });

    app.get('*', function(req, res) {
        res.render('index', { req: req, currentUser: req.user});
    });
};