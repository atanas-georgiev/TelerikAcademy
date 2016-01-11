var users = require('../data/users');
var ads = require('../data/ads');

module.exports = {
    stats: function(req, res, next) {
        ads.all(function(err, dataAds) {
            if (err) {
                res.json(err);
                return;
            }

            users.all(function(err, dataUsers) {
                if (err) {
                    res.json(err);
                    return;
                }

                res.render('index', { req: req, ads: dataAds.length, users: dataUsers.length });
            });
        });
    }
}