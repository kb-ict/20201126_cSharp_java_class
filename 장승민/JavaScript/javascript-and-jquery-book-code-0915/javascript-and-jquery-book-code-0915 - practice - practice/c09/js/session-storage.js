if (Modernizr.sessionstorage) {
    var txtUserName = document.getElementById('username');
    var txtAnswer = document.getElementById('answer');

    txtUserName.value = sessionStorage.getItem('mycat');
    txtAnswer.value = sessionStorage.getItem('answer');
    
    txtUserName.addEventListener('input', function(){
        sessionStorage.setItem('mycat',txtUserName.value);
    },false);

    txtAnswer.addEventListener('input', function(){
        sessionStorage.setItem('answer',txtAnswer.value);
    },false);
};