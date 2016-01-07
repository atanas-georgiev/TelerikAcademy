var jadeParser = require('./jade-parser'),
    data = require('./data')
    http = require('http'),
    url = require('url');

http.createServer(function (req, res) {
    if (req.url === '/') {
        jadeParser.parse('./templates/template.jade', data.parse.home, function (content) {
            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.end(content, 'utf-8');
        });
    } else if (req.url === '/phones') {
        jadeParser.parse('./templates/template.jade', data.parse.phones, function (content) {
            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.end(content, 'utf-8');
        });
    } else if (req.url === '/tablets') {
        jadeParser.parse('./templates/template.jade', data.parse.tablets, function (content) {
            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.end(content, 'utf-8');
        });
    } else if (req.url === '/wearables') {
        jadeParser.parse('./templates/template.jade', data.parse.wearables, function (content) {
            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.end(content, 'utf-8');
        });
    } 
}).listen(1234);

console.log('Server is running on port ' + 1234)


