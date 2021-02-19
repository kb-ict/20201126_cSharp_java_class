var score1=90;
var score2=95;

var highScroe1 = 75;
var highScroe2 = 95;

// 사용자의 점수가 현재의 최고점수보다 높은지 검사
var comparison = ((score1+score2)>(highScroe1+highScroe2))

var el = document.getElementById('answer');
el.innerHTML='신기록 달성: '+ comparison;