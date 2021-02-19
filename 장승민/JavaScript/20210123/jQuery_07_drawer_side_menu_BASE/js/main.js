$(function () {
    var $aside = $('aside'),
        $button = $aside.find('button'),
        $duration = 300;

    //버튼을 클릭하면 aside가 나오도록 해주세요.
    // JS : 선택자.classList.add = 'open';
    // jQuery : A.addClass('b c'); A.removeClass('b');
    // A.toggleClass('b'); -> class가 있으면 remove / class 없으면 add
    // A.hasClass('b')조건문에서만 사용. A요소에 b라는 클래스 있으면 true 없으면 false

    // 속성변경하기, 속성 값 반환하기
    // var c = A.attr('b') => A라는 요소의 b라는 속성의 값을 변수 c에 저장
    // console.log($button.find('img').attr('src'));
    // A.attr('b','c') a라는 요소의 b라는 속성의 값을 c로 변경


    $button.click(function () {
        $aside.toggleClass('open');
        // $aside.stop().animate({left:'0px'},$duration);
        if ($aside.hasClass('open')) {
            // $aside.stop().animate({
            //     left: '-70px'
            // }, $duration, 'easeOutBack');
            $button.find('img').attr('src', 'img/btn_close.png')
        } else {
            // $aside.stop().animate({
            //     left: '-350px'
            // }, $duration, 'easeInBack');
            $button.find('img').attr('src', 'img/btn_open.png')

        };

    });


});