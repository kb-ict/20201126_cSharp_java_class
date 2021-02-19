var pass = 50;
var score = 90;

// 사용자가 시험에 합격했는지를 검사
var hasPassed = score >= pass;

var el = document.getElementById('answer');
el.innerHTML ='합격여부: '+ hasPassed;