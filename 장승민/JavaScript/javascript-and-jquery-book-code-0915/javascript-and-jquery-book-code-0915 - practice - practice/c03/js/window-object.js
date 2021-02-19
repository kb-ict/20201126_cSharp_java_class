var msg = '<h2>브라우저</h2><p>너비: '+ window.innerWidth +'</p>';
msg += '<p>높이 : ' + window.innerHeight +'</p>';
msg += '<h2>히스토리</h2><p>아이템 : ' + window.history.length +'</p>';
msg += '<h2>화면</h2><p>너비 : ' + window.screen.width +'</p>';
msg += '<p>높이 : ' + window.screen.height +'</p>';

var el = document.getElementById('info');
el.innerHTML = msg;
alert('현재 페이지 :' +window.location);