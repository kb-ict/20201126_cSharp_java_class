var originalNumber = 10.23456;
var msg = '<h2>원래 숫자</h2><p>'+originalNumber+'</p>';
msg +='<h2>소수점 반올림</h2><p>'+originalNumber.toFixed(3)+'</p>';
msg +='<h2>3자리 반올림</h2><p>'+originalNumber.toPrecision(3)+'</p>';

var el=document.getElementById('info');
el.innerHTML = msg;