var mongoose = require('mongoose');

module.exports.init = function () {
	var adSchema = mongoose.Schema({
		name: { type: String, require: true},
		description: { type: String, require: true },
		user: { type: mongoose.Schema.Types.ObjectId, required: true },
		picturePath: String,
		pictureFile: String,
		comments: {
			user: mongoose.Schema.Types.ObjectId,
			comment: String
		}
	});
	
	//adSchema.method({
	//	authenticate: function (password) {
	//		if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
	//			return true;
	//		}
	//		else {
	//			return false;
	//		}
	//	}
	//});
	
	var Ad = mongoose.model('Ad', adSchema);
};
