var Ad = require('mongoose').model('Ad');

module.exports = {
	create: function (ad, callback) {
		Ad.create(ad, callback);
	}
};