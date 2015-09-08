var dataMessage = (function () {

    function displayMessage(typeParam, message) {
        var messageToSend = {
            text: message,
            type: typeParam
        };

        templates.get('message')
            .then(function (template) {
                $('#messages').html(template(messageToSend));
            });
    }

    function info(message) {
        displayMessage('alert-info', 'Info: ' + message);
    }

    function success(message) {
        displayMessage('alert-success', 'Success: ' + message);
    }

    function warning(message) {
        displayMessage('alert-warning', 'Warning: ' + message);
    }

    function error(message) {
        displayMessage('alert-danger', 'Error: ' + message);
    }

    return {
        info: info,
        success: success,
        warning: warning,
        error: error
    };

}());
