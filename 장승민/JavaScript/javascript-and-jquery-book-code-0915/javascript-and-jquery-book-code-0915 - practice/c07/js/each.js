$(function(){
    $('li').each(function(){
        var ids = this.id;
        console.log(ids);
        $(this).append(' <span class="order" >'+ ids + '</span>');
    })
})