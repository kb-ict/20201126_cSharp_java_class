$(function () {
    var number = $('#btn');
         $('.btn1').off("click").on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '1';
            });
        };
    });
    $('.btn2').on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '2';
            });
        };
    });
    $('.btn3').on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '3';
            });
        };
    });
    $('.btn4').on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '4';
            });
        };
    });
    $('.btn5').on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '5';
            });
        };
    });
    $('.btn6').on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '6';
            });
        };
    });
    $('.btn7').on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '7';
            });
        };
    });
    $('.btn8').on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '8';
            });
        };
    });
    $('.btn9').on('click', function () {
        if (number.length < 3) {
            $('.number').html(function (index, html) {
                return number += '9';
            });
        };
    });


});