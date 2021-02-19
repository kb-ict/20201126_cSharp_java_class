$('nav a').on('click', function (e) {
    e.preventDefault();
    var url = this.href;
    var $content = $('#content');

    $('nav a.current').removeClass('current');
    $(this).addClass('current');
    $('#container').remove();

    $.ajax({
        type: "GET",
        url: url,
        timeout: 2000,
        beforeSend: function () {
            $content.append('<div id="load">로드중</div>');
        },
        complete: function () {
            $('#load').remove();
        },
        success: function (data) {
            $content.html($(data).find('#container'))
                .hide().fadeIn(400);
        }, fail : function(){
            $('#panel').html('<div class = "loading">장시 후에 다시 시도해주세요.</div>');
        }
    });
});