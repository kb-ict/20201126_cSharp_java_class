var msg = '10% 할인을 받으시려면 지금 회원으로 가입하세요!';

function updateMessage(){
    var el = document.getElementById('message');
    el.textContent=msg;
}
updateMessage();