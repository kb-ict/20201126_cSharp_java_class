function checkUsername() {
    var username = el.value;
    if (username.length < 5) {
        elMsg.className = 'warning';
        elMsg.textContent = 'Name is too short';
    } else {
        elMsg.textContent ="";
    }
}

function tipUsername(){
    elMsg.className = 'tip';
    elMsg.innerHTML = 'Name has to have over 5 words';
}
var el = document.getElementById('username');
var elMsg = document.getElementById('feedback');

el.addEventListener('focus',tipUsername, false);
el.addEventListener('blur', checkUsername, false);