$(function(){
    var $p = $('p');
    var $clonedQuote = $p.clone();
    $p.remove();
    $clonedQuote.insertAfter('h2');

    var $moveItem = $('#one').detach();
    $moveItem.appendTo('ul');
})