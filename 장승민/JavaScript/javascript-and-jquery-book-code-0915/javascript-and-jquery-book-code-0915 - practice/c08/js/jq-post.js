$('#register').on('submit', function(){
    e.preventDefault();
    var details = $('register').serialize();
    $.post('resister.php', details, function(data){
        $('#register').html(data);
    });
});