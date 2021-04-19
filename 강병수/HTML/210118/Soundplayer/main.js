//window 객체는 웹브라우저 전체를 의미한다고 보면 된다.
//398p
//많이 쓰이는건 document 객체를 많이 씀
window.addEventListener('load',
    function () {
        //클래스명이 sound인 것을 모두 불러움
        const sounds = document.querySelectorAll(".sound");
        //클래스명이 pads인 태그의 후손 중에서 div태그들 모두 불러옴
        const pads = document.querySelectorAll(".pads div");
        //클래스이름이 visual인 태그 하나 선택
        const visual = document.querySelector('.visual');
        const title = document.querySelector('.title');

        // 초기화할 때 쓰임
        const colors = ["royalblue", " yellowgreen", "rosybrown", "greenyellow", "brown", "navy"];

        //재생되는 음악이 끝나면, .visual에서 비주얼과 제목 제거

        sounds.forEach(
            function (snd) {
                snd.onended = function (snd) {
                    visual.innerHTML = "";
                    title.innerHTML = "";
                }
            }
        );

        pads.forEach(
            function (pad, index) {
                pad.addEventListener('click',
                    function () {
                        //클래스 이름이 sound인 태그들 각각에 대하여
                        sounds.forEach(function (inx) {
                            //모두 소리를 정지시킨다.
                            inx.pause();
                        });

                        if (sounds[index]) //내가 클릭한 태그
                        {
                            sounds[index].cuirrentTime = 0;
                            sounds[index].play();

                            //음악 제목 출력
                            const strArray = sounds[index].src.split("sound/");
                            title.innerHTML = strArray[1];
                        }
                        //볼만들고 애니메이션 하기
                        createBubbles(index);
                    });
            });

            const createBubbles = function(index)
            {
                visual.innerHTML="";
                //div 태그 생성
                const bubble = document.createElement("div");
                //visual 태그 안에 div 태그 하나 집어넣는다
                visual.appendChild(bubble);
                bubble.style.backgroundColor = colors[index];
                bubble.style.top = '300px';
                //animation 관련된 것은 html 책 참고
                bubble.style.animation = 'animation 2000ms linear infinite both';
            }
    }
)