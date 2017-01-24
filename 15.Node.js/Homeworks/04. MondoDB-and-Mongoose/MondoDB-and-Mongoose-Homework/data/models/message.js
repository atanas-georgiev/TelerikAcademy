var mongoose = require('mongoose');

module.exports.init = function () {
    var messageSchema = new mongoose.Schema({
        from: { type: mongoose.Schema.Types.ObjectId, required: true },
        to: { type: mongoose.Schema.Types.ObjectId, required: true },
        text: { type: String, required: true }
    });
    
    var Message = mongoose.model('Message', messageSchema);
};

