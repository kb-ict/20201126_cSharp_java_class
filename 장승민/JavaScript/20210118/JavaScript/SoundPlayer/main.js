// window 객체는 웹브라우저 전체를 의미한다고 보면 된다.
// p398
window.addEventListener('load',
    function () {
        // 클래스명이 sound인 것을 모두 선택함
        const sounds = document.querySelectorAll('.sound');

        // 클래스명이 pads인 태그의 후손 중에서 div 태그들 모두 선택함
        const pads = document.querySelectorAll('.pads div');

        const visual = document.querySelector('.visual');

        const title = document.querySelector('.title');

        const colors = ["magenta", "orange", "slateblue", "papayawhip", "olive", "mediumspringgreen"];

        sounds.forEach(
            function (snd) {
                snd.onended = function () {
                    visual.innerHTML = '';
                    title.innerHTML = '';
                }
            });
        // 참고하기(적지말기)
        /* sounds.forEach(
            snd=>{
                snd.onended = function(){
            visual.innerHTML='';
            title.innerHTML='';
                }}
        }); */

        pads.forEach(function (pad, index) {
            pad.addEventListener('click', function () {
                //기존에 재생되는 음악을 중지 시켜야 한다.
                sounds.forEach(function (inx) {
                    //console.log(inx);
                    inx.pause();
                });
                if (sounds[index]) {
                    sounds[index].currentTime = 0;
                    sounds[index].play();

                    //뮤직 제목을 출력해 준다.
                    //console.log(sounds[index].src) ;
                    const strArray = sounds[index].src.split("sound/");
                    title.innerHTML = strArray[1];
                }

                //볼만들고 애니메이션 하기
                createBubbles(index);
            });
        });

        const createBubbles = function (index) {
            visual.innerHTML = '';


            // div 태그 생성
            const bubble = document.createElement('div');
            visual.appendChild(bubble);
            bubble.style.backgroundColor=colors[index];
            bubble.style.top='300px';
            // animation 관련된 건 html 책 참고
            bubble.style.animation = 'animation 2000ms linear infinite both'



        }
    });