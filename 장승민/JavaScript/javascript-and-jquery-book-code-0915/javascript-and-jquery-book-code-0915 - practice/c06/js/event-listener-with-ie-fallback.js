var elUsername = document.getElementById('username');
var elMsg = document.getElementById('feedback');

function checkUsername(minLength) {
    if (elUsername.value.length < minLength) {
        elMsg.innerHTML = 'name have to over' + minLength + ' words.';

    } else {
        elMsg.innerHTML = "";
    }
}

if(elUsername.addEventListener){
elUsername.addEventListener('blur', function () {
    checkUsername(5);
}, false);
} else {
    elUsername.attachEvent('onblur',function(){
        checkUsername(5);
    });
}
