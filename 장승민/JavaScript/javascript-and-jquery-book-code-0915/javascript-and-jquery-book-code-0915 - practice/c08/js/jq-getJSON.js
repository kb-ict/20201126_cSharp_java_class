$('#exchangerates').append('<div id ="rates"></div><div id ="reload"></div>');

function loadRates() {
    $.getJSON('data/rates.json')
        .done(function (data) {
            var d = new Date();
            var hrs = d.getHours();
            var mins = d.getMinutes();
            var msg = '<h2>환율 정보</h2>';
            $.each(data, function (key, val) {
                msg += '<div class="' + key + '">' + key + ': ' + val + '</div>';
            });
            msg += '<br>최종수정시간: ' + hrs + ':' + mins + '<br>';
            $('#rates').html(msg);
        }).fail(function () {
            var msg = '<h2>환율 정보</h2>';
            msg += '<div>환율 정보를 로드하지 못했습니다.</div>';
            $('#rates').html(msg);
        }).always(function(){
            var reload = '<a id = "refresh" href="#">';
            reload+='<img src = "img/refresh.png" alr ="refresh" /></a>';
            $('#reload').html(reload);
            $('#refresh').on('click', function(e){
                e.preventDefault();
                loadRates();
            });
        });
}
loadRates();
