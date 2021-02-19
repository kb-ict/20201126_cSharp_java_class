$(function () {
    var ids = "";
    var $listItems = $('li');
    $listItems.on('mouseover click', function () {
        ids = this.id;
        $(this).children('span').remove();
        $(this).append(' <span >' + ids + '</span>');
    }).on('mouseout', function () {
        $(this).children('span').remove();
    })

})