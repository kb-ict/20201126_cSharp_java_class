var score=75;
var pass =50;
var msg;

if(score>=pass){
    msg ='축하합니다.합격입니다.';
} else {
    msg = '다시 한번!';
}

document.getElementById('answer').innerHTML = msg;