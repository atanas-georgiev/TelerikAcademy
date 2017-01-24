﻿var mongoose = require('mongoose');

module.exports.init = function () {
    var userSchema = new mongoose.Schema({
        username: { type: String, required: true, unique: true },
        password: { type: String, required: true }
    });
    
    var User = mongoose.model('User', userSchema);
};

