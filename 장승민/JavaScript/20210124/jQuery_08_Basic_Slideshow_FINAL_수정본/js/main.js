$(function () {

  // 변수 지정
  var slides = $('.slideshow img'),
    slideCount = slides.length,
    currentIndex = 0;

    //해당 시간이 지나면 한번만 할일
    // var timer = setTimeout(할일,1000);
    // clearTimeout(timer);

    //일정 시간 마다 할 일
    // var timer =  setInterval(할일, 시간);
    // clearInterval(timer);

    // jquery 집합개체(object)중 특정번째 요소 선택 .eq
    // eq = equivalent 동등한
    // 요소를 서서히 나타나도록 .fadeIn() 
    // 요소를 서서히 사라지도록 .fadeOut() 


   var timer =  setInterval(showNextSlide, 3500);
      

    function showNextSlide(){
      // slideCount 4
      var nextIndex = (currentIndex+1)%slideCount;

      // 현재슬라이드가 사라지고
      slides.eq(currentIndex).fadeOut();
      // 다음 슬라이드가 나타남
      slides.eq(nextIndex).fadeIn();
      currentIndex = nextIndex;
      console.log(currentIndex);

    }// shoeNextSlide
      function timeron(){
        setInterval(showNextSlide, 3500);

      }
      function timeroff(){
        clearInterval(timer);
      }
    slides.mouseover(function(){
      timeroff();

    })
    .mouseout(function(){
      timeron();
    });



   
});





/*
$(function () {
    // 변수지정
        var slides = $('.slideshow img'), 
            slideCount = slides.length, 
            currentIndex = 0; 

            slides.eq(currentIndex).fadeIn();			
			
		var timer = undefined;  //타이머의 값을 undefined(지정되어 있지 않다)라고 지정합니다.
			
		if (timer == undefined) { //타이머의 값이 undefined이면 showNextslide를 3.5s 마다 실행하라고 합니다.
			timer = setInterval(showNextSlide, 3500);
		}         

            function showNextSlide(){

              var nextIndex = (currentIndex + 1) % slideCount;

              slides.eq(currentIndex).fadeOut();
              slides.eq(nextIndex).fadeIn();
              currentIndex = nextIndex;

              console.log(currentIndex);

            }

            function timeron(){
			if (!timer) { //타이머의 값이 undefined이면 showNextslide를 3.5s 마다 실행하라고 합니다.
				timer = setInterval(showNextSlide, 3500);
			  } 
            }
            function timeroff(){
			  if (timer) { //타이머의 값이 있으면 즉 setInterval(showNextSlide, 3500)값이 있으면 클리어하고 값을 다시 undefined로 저장.
				clearInterval(timer);
				timer = undefined;				
			  }	
            }

            slides.mouseenter(function(){
              timeroff();
            })
            .mouseleave(function(){
              timeron();
            })


});
*/