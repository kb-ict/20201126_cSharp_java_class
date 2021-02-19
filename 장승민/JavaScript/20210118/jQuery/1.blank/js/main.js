//     document.addEventListener('DOMContentLoaded',function () {
//    document.getElementsByTagName('h1')[0].style.color='red';
//     })

// $(document).ready(function(){
//     $('h1').css({'color':'red'});
// })

$(function(){
    $('h1').css('color','red');// Css 속성 하나를 변경

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

    $('#typo .inner').css({
        textDecoration:'underLine',
        borderBottom:'5px solid red',
        transform:'rotate(45deg)',
        opacity:'0.5'
    })
})
 