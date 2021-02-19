$(function () {
    var $duration = 300,
        $image = $('#images p');

    // 첫번째 캡션, span animate 메쏘드
    /*
    공백 o -> find
    공백 x -> filter
    css                     jQuery
    #images p span { }      -> $image.find('span')
    #images p.strong { }    -> $image.filter('strong')

    선택자.animate({속성 : 값 , 속성 : 값}, 시간, 이징, 다른 할일);\

    span, strong {opacity : 1 }
     */


    $image.filter(':nth-child(1)').mouseover(function () {
        $(this).find('span, strong').animate({
            opacity: 1
        }, $duration);
    }).mouseout(function () {
        $(this).find('span, strong').animate({
            opacity: 0
        }, $duration);
    });

    // #images p:nth-child(2)
    // $image.filter(':nth-child(2)')


    $image.filter(':nth-child(2)').mouseover(function () {
        $(this).find('span').stop().animate({
            opacity: 1
        }, $duration);
        $(this).find('strong').stop().animate({
            opacity: 1,
            left : '0%'
        }, $duration);
    }).mouseout(function () {
        $(this).find('span').stop().animate({
            opacity: 0
        }, $duration);
        $(this).find('strong').stop().animate({
            opacity: 0,
            left : '-200%'
        }, $duration);
    });

    $image.filter(':nth-child(3)').mouseover(function () {
        $(this).find('span').stop().animate({
            opacity: 1
        }, $duration);
        $(this).find('strong').stop().animate({
            opacity: 1,
            bottom : 0
        }, $duration);
        $(this).find('img').stop().animate({
            opacity: 1,
            top:'-40px'
        }, $duration);
        }).mouseout(function () {
            $(this).find('span').stop().animate({
                opacity: 0
            }, $duration);
            $(this).find('strong').stop().animate({
                opacity: 1,
                bottom : '-80px'
            }, $duration);
            $(this).find('img').stop().animate({
                opacity: 1,
                top:0
            }, $duration);
    });
});