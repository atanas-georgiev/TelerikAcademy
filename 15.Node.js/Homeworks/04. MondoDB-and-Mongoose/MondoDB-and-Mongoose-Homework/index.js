var chatDb = require('./chat-db');

console.log('Creating users:');
chatDb.registerUser({ user: 'DonchoMinkov', pass: '123456q' });
chatDb.registerUser({ user: 'NikolayKostov', pass: '123456q' });

console.log('Add messages:');
chatDb.sendMessage({
    from: 'DonchoMinkov',
    to: 'NikolayKostov',
    text: 'Hey, Niki!'
});

chatDb.sendMessage({
    from: 'DonchoMinkov',
    to: 'NikolayKostov',
    text: 'Hey, Niki again!'
});

console.log('Return all messages from the participants:');
chatDb.getMessages({
    with: 'DonchoMinkov',
    and: 'NikolayKostov'
});