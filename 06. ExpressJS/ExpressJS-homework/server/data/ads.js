var Ad = require('mongoose').model('Ad');

module.exports = {
	create: function (ad, callback) {
		Ad.create(ad, callback);
    },
    getById: function (id, callback) {
        Ad.findOne()
	        .where('_id').equals(id)
	        .exec(function (err, ad) {
                callback(err, ad);
            });
    }, 
    all: function (callback) {
        Ad.find()	        
	        .exec(function (err, ad) {
            callback(err, ad);
        });
    }
};