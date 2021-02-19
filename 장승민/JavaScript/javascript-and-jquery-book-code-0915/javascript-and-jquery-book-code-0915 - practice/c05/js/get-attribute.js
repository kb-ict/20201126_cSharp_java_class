var firstItem = document.getElementById('one');

if(firstItem.hasAttribute('class')){
    var attr = firstItem.getAttribute('class');

    var el = document.getElementById('scriptResults');
    el.innerHTML='<p>첫 번째 아이템의 클래스 이름은 '+attr+'입니다.</p>'
}