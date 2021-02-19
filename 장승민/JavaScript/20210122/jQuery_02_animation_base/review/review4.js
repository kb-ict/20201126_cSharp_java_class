
$(function(){
	$('div').mouseover(function(){
		$(this).stop(true).animate({backgroundColor:'blue'},500);
	}).mouseout(function(){
		$(this).stop(true).animate({backgroundColor:'green'},500);
	});

});