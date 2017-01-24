(function () {
	'use strict';
	
	var formidable = require('formidable'),
		http = require('http'),
		util = require('util'),
		fs = require('fs-extra'),
		url = require('url'),
		uuid = require('node-uuid'),
		path = require('path'),
		port = 12345;
	
	// create server
	http.createServer(function (req, res) {
		
		if (req.url == '/upload' && req.method.toLowerCase() == 'post') {
			
			var form = new formidable.IncomingForm();
			var guid = uuid.v1();
			
			form.parse(req, function (err, fields, files) {
				res.writeHead(200, { 'content-type': 'text/html' });
				res.write('<h1>Upload completed!</h1>');
				res.write('<h2>Stored as: </h4>' + guid + '</h2>');
				res.end('<div><a href="/">Back</a></div>');
			});

			form.on('end', function (fields, files) {
				var temp_path = this.openedFiles[0].path;
				var file_name = this.openedFiles[0].name;
				var new_full_path = __dirname + '/uploads/' + guid + path.extname(file_name);				
				
				fs.copy(temp_path, new_full_path, function (err) {
					if (err) {
						console.error(err);
					} else {
						console.log("success!")
					}
				});
			});
			return;
		}
		
		// Initial html data
		res.writeHead(200, { 'content-type': 'text/html' });
		res.write('<h1>File uploader!</h1>');	
		res.write('<form action="/upload" method="post" enctype="multipart/form-data">');
		res.write('<input type="file" name="upload" multiple="multiple"><br>');
		res.write('<input type="submit" value="Upload"></form>');
		res.end();

	}).listen(port);

	console.info('App running on localhost:' + port);

}());