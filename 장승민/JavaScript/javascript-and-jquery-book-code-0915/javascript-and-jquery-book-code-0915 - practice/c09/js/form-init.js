$(function(){
    $('#arrival').datepicker();

    var $amount = $('#amount');
    var $range = $('#price-range');

    $('#price-range').slider({
        range:true, 
        min:0, 
        max:400,
        values:[175, 300], 
        slide: function(event, ui){
            $amount.val('$'+ui.values[0]+' - S'+ui.values[1]);
        
        }
    });
    $amount.val('$'+$range.slider('values', 0)
    +' - $'+$range.slider('values', 1));

})