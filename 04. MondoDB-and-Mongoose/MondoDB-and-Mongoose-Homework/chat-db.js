var mongoose = require('mongoose'),
    fs = require('fs');

mongoose.connect('mongodb://localhost/chatSystem');

require('./data/models/user').init();
require('./data/models/message').init();

var users = require('./data/users'),
    messages = require('./data/messages');

exports.registerUser = function (user) {
    var newUser = {
        username : user.user,
        password : user.pass
    };
    
    users.create(newUser, function (err) {
        if (err) {
            console.log('User ' + newUser.username + ' exist!')
        }
        else {
            console.log('User ' + newUser.username + ' created!');
        }        
    })
};

exports.sendMessage = function (message) {
    
    users.get(message.from, function (err, res) {
        if (err) {
            console.log('User ' + message.from + ' do not exist!');
            return;
        }
        message.from = res;

        users.get(message.to, function (err, res) {
            if (err) {
                console.log('User ' + message.to + ' do not exist!');
                return;
            }
            
            message.to = res;
            messages.create(message, function (err, res) {
                if (err) {
                    console.log('Message ' + message.text + ' not sent!');
                    return;
                }
                console.log(res);
            });
        });

    });
};

exports.getMessages = function (participants) {
   
    users.get(participants.with, function (err, res) {
        if (err) {
            console.log('User ' + participants.with + ' do not exist!');
            return;
        }
        participants.with = res;
        
        users.get(participants.and, function (err, res) {
            if (err) {
                console.log('User ' + participants.and + ' do not exist!');
                return;
            }
            
            participants.and = res;
            messages.get(participants, function (err, res) {
                console.log(res);
            });

        });
     });
};
