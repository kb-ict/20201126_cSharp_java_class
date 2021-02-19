var score=75;
var msg;

if(score>=50){
    msg ='축하합니다!<br>'
    msg+='다음 단계를 진행합니다.';
}

document.getElementById('answer').innerHTML = msg;