//Problem 9. Extract e-mails
//
//Write a function for extracting all email addresses from given text.
//    All sub-strings that match the format @… should be recognized as emails.
//    Return the emails as array of strings.

function problem09_ExtractEmails() {
    'use strict';

    var emails = 'riojasm66@yahoo.com, hdclive@live.com, terauau@gmail.com, jabu_moleketi@yahoo.com, soeungkheng34@yahoo.com, desk433@yahoo.com, caf432@ig.com.br',
        mailList = emails.match(/.+\@.+\..+/g).map(String);

    console.log(mailList);
}