if (Modernizr.localstorage) {

    var txtUserName = document.getElementById('username');
    var txtAnswer = document.getElementById('answer');

    txtUserName.value = localStorage.getItem('username');
    txtAnswer.value = localStorage.getItem('answer');

    txtUserName.addEventListener('input', function(){
        localStorage.setItem('username', txtUserName.value);
    },false);
    
    txtAnswer.addEventListener('input', function(){
        localStorage.setItem('answer',txtAnswer.value);
    },false);
};