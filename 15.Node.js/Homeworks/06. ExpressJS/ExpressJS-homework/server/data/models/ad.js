var mongoose = require('mongoose');

module.exports.init = function () {
	var adSchema = mongoose.Schema({
		name: { type: String, require: true},
		description: { type: String, require: true },
		username: { type: String, require: true },
		pictureFile: String,
		comments: {
			user: mongoose.Schema.Types.ObjectId,
			comment: String
		}
	});
	
	var Ad = mongoose.model('Ad', adSchema);
};
