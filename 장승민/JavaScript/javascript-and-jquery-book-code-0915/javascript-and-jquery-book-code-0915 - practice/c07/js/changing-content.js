$(function(){
  $('li:contains("pine nuts")').text('아몬드');
  $('li.hot').html(function(){
      return '<en>'+$(this).text()+'</em>';
  });
  $('li#one').remove();
})