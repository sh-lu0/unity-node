var WebSocketServer = require('ws').Server
var wss = new WebSocketServer({
    port: 8080
});

wss.on('connection', function (ws) {
    ws.on('message', function (message) {
        console.log('received: %s', message)
        // 送る
        ws.send(message)
    });
    ws.send('This is server')
});
