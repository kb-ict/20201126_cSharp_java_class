//javaScript는 따옴표와 쌍따옴표 모두 문장정의에 사용됨
//'load'
//"load"

// java
//char a = 'j'
//String b = "JJJ";

//window 객체는 웹브라우저 전체를 의미한다고 보면 된다.
//398p
//많이 쓰이는 건 documnet 객체를 많이 씀

// js
// window.addEventListener('load',

// jquery
$(document).ready(function () {



        //클래스명이 sound인 것을 모두 선택함(=불러옴)
        // const sounds = document.querySelectorAll(".sound");
        const sounds = $(".sound");


        //클래스명이 pads인 태그의 후손 중에서 div태그들 모두 불러옴
        // const pads = document.querySelectorAll(".pads div");
        const pads = $(".pads div");

        //클래스이름이 visual인 태그 하나 선택
        // const visual = document.querySelector('.visual');
        const visual = $('.visual');

        //클래스이름이 title인 태그 하나 선택
        // const title = document.querySelector('.title');
        const title = $('.title');

        // 초기화할 때 쓰임
        const colors = ["lightseagreen",
            "rebeccapurple",
            "deepskyblue",
            "coral",
            "rgb(100, 168, 86)",
            "brown"
        ];

        //재생되는 음악이 끝나면, .visual에서 비쥬얼과 제목 제거
        /*sounds.forEach(
            function (soundFile) {
                soundFile.onended = function () {
                    visual.innerHTML = "";
                    title.innerHTML = "";
                }
            }

        );*/
        sounds.each(function (index, soundFile) {
            soundFile.onended = function () {
                // visual.innerHTML = "";
                visual.text('');
                // title.innerHTML = "";
                title.text('');
                // 참고
                // 값읽을때 괄호안에 아무것도 넣지말아야함
                // visual.text();

                // 값 쓸때는 괄호안에 뭔가 있으야함
                // visual.text('aa');

            }
        })
        /* 참고하기(적지말기) */
        /*
             sounds.forEach(snd => {
                snd.onended = function(){
                    visual.innerHTML = "";
                    title.innerHTML = "";
                };
            });
         */

        // pads.forEach(function (pad, index) {
        pads.each(function (index, pad) {
            // pad.addEventListener('click', function () {
            $(pad).on('click', function () {
                // sounds.forEach(function (inx) {
                sounds.each(function (inx, sndf) {
                    sndf.pause(); //sndf:사운드 파일
                });
                if (sounds[index]) {
                    sounds[index].currentTime = 0;
                    sounds[index].play();

                    //뮤직 제목을 출력해 준다.
                    //console.log(sounds[index].src) ;
                    //sound/1.mp3
                    const strArray = sounds[index].src.split("sound/");
                    
                    title.text(strArray[1]) ;
                }
                createBubbles(index);
            })

        });
        //javaScript
        /* const createBubbles = function (index) {
             visual.innerHTML = "";
             //div 태그 생성
             const bubble = document.createElement("div");
             //visual 태그 안에 div 태그 하나 집어넣는다.
             visual.appendChild(bubble);
             bubble.style.backgroundColor = colors[index];
             bubble.style.top = '300px';
             //animation 관련된 건 html책 참고
             bubble.style.animation = 'animation 2000ms linear infinite both';
         */

        //    jquery
        const createBubbles = function (index) {
            visual.text('');
            const bubble = $("<div></div>");
            // visual 태그안에 div 태그 하나 집어넣는다
            visual.append(bubble);
            // animation관런된건 html 책 참고
            // bubble.css('background', colors[index]).css('top', '300px').css('animation', 'animation 2000ms linear infinite both')
            
            bubble.css('background', colors[index]).css('top','300px').
            css('animation', 'animation 2000ms linear infinite both')
        }

    }

);