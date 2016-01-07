var jade = require('jade'),
    fs = require('fs');

module.exports.parse = function (templateFile, data, callback) {
    fs.readFile(templateFile, 'utf-8', function (err, content) {
        if (err) throw err;
        var template = jade.compile(content);
        var output = template(data);
        
        callback(output);
    });
}