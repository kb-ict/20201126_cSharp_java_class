var msg = '<p><b>페이지 제목:</b>' + document.title +'<br>';
msg+='<b>페이지 주소: </b>'+document.URL +'<br>';
msg += '<b>최종 수정일: </b>' + document.lastModified + '</p>';

var el = document.getElementById('footer');
el.innerHTML =msg;