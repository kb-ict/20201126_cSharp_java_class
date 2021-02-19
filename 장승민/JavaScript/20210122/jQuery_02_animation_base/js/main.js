$(function () {
    $('#typo, h1').mouseover(function () {
        $(this).css('background-color', 'green');
    });
    $('#typo, h1').mouseout(function () {
        $(this).css('background-color', '#3498db');
    });

    // review 1

    $(function () {
        $('.menu li').mouseover(function () {
            $(this).css('backgroundColor', '#ccc');
        });
    });




});