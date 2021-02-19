var elMap = document.getElementById('loc');
var msg = '현재 위치 정보를 얻을수 없습니다.';

if (Modernizr.geolocation) {
    navigator.geolocation.getCurrentPosition(success, fail);
    elMap.textContent = '위치 확인 중...';
} else {
    elMap.textContent = msg;
}

function success(location) {
    msg = '<h3>위도 : <br>';
    msg += location.coords.latitude + '</h3>';
    msg += '<h3>경도 : <br>';
    msg += location.coords.longitude + '</h3>';
    elMap.innerHTML = msg;
}

function fail(msg) {
    elMap.textContent = msg;
    console.log(msg.code);
}