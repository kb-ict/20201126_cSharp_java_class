// 새로운 Date 객체를 저장할 변수를 선언한다
var today = new Date();
// 현재 연도를 저장할 변수를 선언
var year = today.getFullYear();

// ID 특성이 footer인 요소를 저장할 el 변수를 선언한다
var el = document.getElementById('footer');
// 연도 값 출력
el.innerHTML='<p>Copyright &copy;'+ year+'</p>';