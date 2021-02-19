//     document.addEventListener('DOMContentLoaded',function () {
//    document.getElementsByTagName('h1')[0].style.color='red';
//     })

// $(document).ready(function(){
//     $('h1').css({'color':'red'});
// })

$(function () {
    $('h1').css('color', 'red'); // Css 속성 하나를 변경

    // // 아이디 type안에 클래스 .inner  css 속성 밑줄긋기
    // $('#typo .inner').css('text-decoration','underLine');

    // $('#typo .inner').css('border-bottom','5px solid red');

    // $('#typo .inner').css('transform','rotate(45deg)');

    // $('#typo .inner').css('opacity',0.5);


    // $('#typo .inner').css({
    //     'text-decoration':'underLine',
    //     'border-bottom':'5px solid red',
    //     'transform':'rotate(45deg)',
    //     'opacity':'0.5'
    // })

    // $('#typo .inner').css({
    //     textDecoration:'underLine',
    //     borderBottom:'5px solid red',
    //     transform:'rotate(45deg)',
    //     opacity:'0.5'
    // })

    // 실행 시점 제어 - event종류 - mouseover 마우스가 올라왔을 때
    // on 메쏘드, -> 엤날 :  bind('click'...) -> 요즘 : .on .off
    // $('선택자').on('이벤트 종류',할일);
    //할 일 = 임의 함수  = function(){};

    // $('#typo').on('mouseover', function () {
    //     // 아이디 typo의 배경색을 green으로 바꿈
    //     $('#typo').css('background-color', 'green');
    // }); //typo mouseover


    // // 마우스가 나가면 다시 원래 색상으로 변함
    // $('#typo').on('mouseout', function () {
    //     // 아이디 typo의 배경색을 green으로 바꿈
    //     $('#typo').css('background-color', '#3498db');
    // }); //typo mouseout

    // @@@    메쏘드 체인   @@@
    // $('#typo').on('mouseover', function () {
    //     // 아이디 typo의 배경색을 green으로 바꿈
    //     $('#typo').css('background-color', 'green');
    // }).on('mouseout', function () {
    //     // 아이디 typo의 배경색을 green으로 바꿈
    //     $('#typo').css('background-color', '#3498db');
    // }); //typo mouseout

    // $('#typo').mouseover(function () {
    //     // 아이디 typo의 배경색을 green으로 바꿈
    //     $('#typo').css('background-color', 'green');
    // }).mouseout(function () {
    //     // 아이디 typo의 배경색을 green으로 바꿈
    //     $('#typo').css('background-color', '#3498db');
    // }); //typo mouseout

    $('#typo, h1').mouseover(function () {
        // 아이디 typo의 배경색을 green으로 바꿈
        $(this).css('background-color', 'green');
    }).mouseout(function () {
        // 아이디 typo의 배경색을 green으로 바꿈
        $(this).css('background-color', '#3498db');
    }); //typo mouseout


});