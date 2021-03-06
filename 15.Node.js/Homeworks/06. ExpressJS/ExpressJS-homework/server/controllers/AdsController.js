﻿var encryption = require('../utilities/encryption'),
    uploading = require('../utilities/uploading'),
    ads = require('../data/ads'),
    path = require('path');

var CONTROLLER_NAME = 'ads';

module.exports = {
    getAdd: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/add', { req: req })
    },
    postAdd: function (req, res, next) {
        var ad = {};
        ad.username = req.user.username;
        
        req.pipe(req.busboy);        
        
        req.busboy.on('file', function (fieldname, file, filename) {
            var fileNameHashed = encryption.generateHashedPassword(encryption.generateSalt(), filename) + path.extname(filename);        
            var pathName = '/' + ad.username;
            uploading.saveFile(file, pathName, '/' + fileNameHashed);                    
            ad.pictureFile = fileNameHashed;
        });

        req.busboy.on('field', function (fieldname, val) {
            ad[fieldname] = val;            
        });
        
        req.busboy.on('finish', function () {
            ads.create(ad, function(err, data) {
                if (err) {
                    res.json(err);
                    return;
                }
                res.redirect('/ads/' + data._id);
            });
        });
    },
    getAdDetails: function (req, res, next) {
        var id = req.params.id;
        ads.getById(id, function(err, data) {
            if (err) {
                res.json(err);
                return;
            }
            res.render(CONTROLLER_NAME + '/details', { req: req, currentAd: data });
        });
    },
    getAll: function (req, res, next) {
        ads.all(function(err, data) {
            if (err) {
                res.json(err);
                return;
            }
            //res.json(data);
            res.render(CONTROLLER_NAME + '/list', { req: req, data: data });
        }, req.query.text);
    },
    getEdit: function (req, res, next) {
        var id = req.params.id;
        ads.getById(id, function (err, data) {
            if (err) {
                res.json(err);
                return;
            }
            res.render(CONTROLLER_NAME + '/edit', { req: req, data: data });
        });
    },
    postEdit: function (req, res, next) {
        var id = req.params.id;
        var updatedAd = {};
        updatedAd.username = req.user.username;
        
        req.pipe(req.busboy);
        
        req.busboy.on('file', function (fieldname, file, filename) {
            var fileNameHashed = encryption.generateHashedPassword(encryption.generateSalt(), filename) + path.extname(filename);
            var pathName = '/' + updatedAd.username;
            uploading.saveFile(file, pathName, '/' + fileNameHashed);
            updatedAd.pictureFile = fileNameHashed;
        });
        
        req.busboy.on('field', function (fieldname, val) {
            updatedAd[fieldname] = val;
        });
        
        req.busboy.on('finish', function () {
            console.log(updatedAd);  
            ads.editById(id, updatedAd, function (err, data) {
                console.log(req.body);
                if (err) {
                    res.json(err);
                    return;
                }
                console.log('aaaaaaaa');
            req.toastr.success('Updated!');
            res.redirect('/ads/' + id);
            });
        });
    },
    getDelete: function (req, res, next) {
        var id = req.params.id;
        ads.deleteById(id, function (err) {
            if (err) {
                res.json(err);
                return;
            }
            req.toastr.success('Deleted!');
            res.redirect('/ads/list');            
        });
    },
};