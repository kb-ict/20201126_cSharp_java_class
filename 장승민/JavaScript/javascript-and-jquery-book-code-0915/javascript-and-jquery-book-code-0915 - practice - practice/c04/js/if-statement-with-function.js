var score=75;
var msg ='';

function congratulation(){
    msg += '축하합니다! ';
}

if(score>=50){
    congratulation();
    msg+='<br>다음 단계를 진행합니다.';
}

document.getElementById('answer').innerHTML = msg;