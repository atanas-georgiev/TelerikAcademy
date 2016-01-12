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
    },
    editById: function (id, updatedAd, callback) {
        Ad.findOne()
	        .where('_id').equals(id)
	        .exec(function (err, ad) {
            if (err) throw err;
                
            if (!updatedAd.pictureFile) {
                updatedAd.pictureFile = ad.pictureFile;
            }

            ad.update(updatedAd, function (err, data) {
                callback(err, data);
            });
        });
    },
    deleteById: function (id, callback) {
        Ad.remove({ _id: id }, function (err) { 
            callback(err);
        });	       
    },
};