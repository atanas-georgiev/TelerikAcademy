var Message = require('mongoose').model('Message');

module.exports = {
    create: function (message, callback) {
        Message.create(message, callback);
    },
    get: function (participants, callback) {
        Message.find()
	        .where('from').equals(participants.with)
            .where('to').equals(participants.and)
	        .exec(function (err, messages) {
                console.log(messages);      
                callback(err, messages);
        });
    }
};