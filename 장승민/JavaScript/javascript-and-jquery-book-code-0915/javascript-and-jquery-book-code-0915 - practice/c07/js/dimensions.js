$(function(){
    var listHeight = $('#page').height();
    $('ul').append('<p>높이 : '+listHeight+' px</p>');
    $('li').width('50%');
    $('li#one').width(145);
    $('li#two').width('75%');
})