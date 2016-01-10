var express = require('express');

var env = process.env.NODE_ENV || 'development';

// Main express object
var app = express();

// Server configuration
var config = require('./server/config/config')[env];
require('./server/config/express')(app, config);
require('./server/config/mongoose')(config);
require('./server/config/passport')();
require('./server/config/routes')(app);

// Start server
app.listen(config.port);
console.log("Server running on port: " + config.port);