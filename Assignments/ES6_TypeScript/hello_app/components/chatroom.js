let music_users = new Set(['Thom', 'Jonny', 'Colin']);
let sports_users = new Set(['Ronaldo', 'Messi', 'Pogba']);
let music_msg = ['Hey', 'Hello!', 'Guitar', 'Song'];
let sports_msg = ['Hi', 'Hola', 'What\'s up?', 'Football'];

let map = new Map();
map.set('musicUser', music_users);
map.set('musicMessage', music_msg);
map.set('sportsUser', sports_users);
map.set('sportsMessage', sports_msg);

function getUserList(chatroom) {
    if(chatroom == 'music') {
        console.log(map.get('musicUser'))
    }
   if(chatroom == 'sports') {
        console.log(map.get('sportsUser'))
    }
}

function getMessageList(chatroom){
    if(chatroom == 'music') {
        console.log(map.get('musicMessage'))
    }
    if(chatroom == 'sports') {
        console.log(map.get('sportsMessage'))
    }    
}

export{getMessageList as messages, getUserList as users}

