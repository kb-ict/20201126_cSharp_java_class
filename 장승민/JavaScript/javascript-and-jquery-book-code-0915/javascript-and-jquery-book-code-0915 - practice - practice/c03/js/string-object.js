var saying = 'Home sweet home ';
var msg = '<h2>길이</h2><p>'+saying.length+'</p>';
msg +='<h2>대문자</h2><p>'+saying.toUpperCase()+'</p>';
msg +='<h2>소문자</h2><p>'+saying.toLowerCase()+'</p>';
msg +='<h2>문자 인덱스: 12</h2><p>'+saying.charAt(12)+'</p>';
msg +='<h2>ee의 첫 번째 위치</h2><p>'+saying.indexOf('ee')+'</p>';
msg +='<h2>e의 마지막 위치</h2><p>'+saying.lastIndexOf('e')+'</p>';
msg +='<h2>인덱스 범위: 8-14</h2><p>'+saying.substring(8,14)+'</p>';
msg +='<h2>replace</h2><p>'+saying.replace('me','w')+'</p>';

var el =document.getElementById('info');
el.innerHTML = msg;