// JS는 따옴표와 쌍따옴표 모두 문장정의에 사용됨
// 'load'
// "load"

// java
// char a = 'j';
// String b = "JJJ";

// window객체는 웹브라우저 전체 의미함 (전체)
// 책 398 p
// 많이 쓰이는건 document 객체를 많이 씀 (주소창 밑부터)
window.addEventListener('load',
    function () { // 클래스명 sound인 것을 모두 선택함
        const sounds = document.querySelectorAll(".sound");

        // 클래스명 pads인 태그의 후손 중에서 div태그들 모두 선택함
        const pads = document.querySelectorAll(".pads div");

        // 클래스명 visual인 태그하나 선택
        const visual = document.querySelector('.visual');
        // 클래스명 title인 태그하나 선택
        const title = document.querySelector('.title');

        // 초기화할 때 쓰임
        const color = ["orangered", "orange", "lightgreen", "mediumturquoise", "cornflowerblue", "mediumpurple"];

        // 재생음악 끝나면 .visual에서 비쥬얼과 제목 제거
        sounds.forEach(
            function (snd) {
                snd.onended = function() {
                    visual.innerHTML = "";
                    title.innerHTML = "";
                }
            }
        );

        pads.forEach( function(pad, index) {
            pad.addEventListener('click', function(){
                //기존에 재생되는 음악을 중지 시켜야 한다.
               sounds.forEach(function(inx) {
                //console.log(inx);
                inx.pause();
               });
               if(sounds[index]){
                sounds[index].currentTime = 0;
                sounds[index].play();

                //뮤직 제목을 출력해 준다.
                //console.log(sounds[index].src) ;
                const strArray = sounds[index].src.split("sound/");
                // console.log(strArray[0]);
                title.innerHTML = strArray[1];
               }
                //볼만들고 애니메이션 하기
                createBubbles(index);

            });
        });

        const createBubbles = function(index) 
        {
            visual.innerHTML = "";
            //div태그 생성
            const bubble = document.createElement("div");
            //visual태그 안에 div태그 하나 집어넣음.
            visual.appendChild(bubble);
            bubble.style.backgroundColor = color[index];
            bubble.style.top = '300px';

            bubble.style.display = 'inline-block';
            //animation 관련된거 html책 참고, 웹: js, 일반다른직종: JSON구조
            bubble.style.animation = 'animation 2000ms linear infinite both';
        }
    }
);