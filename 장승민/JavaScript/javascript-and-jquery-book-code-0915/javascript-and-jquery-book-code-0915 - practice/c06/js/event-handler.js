function checkUsername(){
    var elMsg = document.getElementById('feedback');
    if(this.value.length<5){
        elMsg.textContent = "이름은 다섯글자 이상이어야 합니다.";
    } else {
        elMsg.textContent = "";
    }
}
var elUsername = document.getElementById('username');
elUsername.onblur = checkUsername;