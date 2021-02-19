$('#selector a').on('click', function(e){
    e.preventDefault();
    var queryString = 'vote=' + $(e.target).attr('id');
    $.get('votes.php', queryString, function(data){
        $('#selector').html(data);
    })
})