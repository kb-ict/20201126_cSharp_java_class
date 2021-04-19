//window 객체는 웹브라우저 전체를 의미한다고 보면 된다.
//398p
//많이 쓰이는건 document 객체를 많이 씀

$(document).ready(function(){ //jQuery

//js
// window.addEventListener('load',
    // function () {
        //클래스명이 sound인 것을 모두 불러움
        // const sounds = document.querySelectorAll(".sound");
        const sounds = $(".sound");
        //클래스명이 pads인 태그의 후손 중에서 div태그들 모두 불러옴
        // const pads = document.querySelectorAll(".pads div");
        const pads = $(".pads div");
        //클래스이름이 visual인 태그 하나 선택
        // const visual = document.querySelector('.visual');
        const visual = $('.visual');
        // const title = document.querySelector('.title');
        const title = $('.title');

        // 초기화할 때 쓰임
        const colors = ["royalblue", " yellowgreen", "rosybrown", "greenyellow", "brown", "navy"];

        //재생되는 음악이 끝나면, .visual에서 비주얼과 제목 제거

        // sounds.forEach(
        //     function (snd) {
        //         snd.onended = function (snd) {
        //         }
        //     }
        // );

        sounds.each(function(index, soundFile)
        {
            soundFile.onended = function()
            {
                // visual.innerHTML = "";
                visual.text('');
                // title.innerHTML = "";
                title.text('');

                // 참고
                // 값 읽을 때
                // var test = visual.text();

                // 값 쓸 때
                // visual.text('aa');
            }
        });

        // pads.forEach(function (pad, index) { js
        pads.each(function(index,pad){ //jQ
        // pad.addEventListener('click',function () { js
            $(pad).on('click', function() { //jQ
        // sounds.forEach(function (inx) { js
                sounds.each(function(inx, sndf) { //jQ
                    sndf.pause(); //사운드 파일
                });
                        if (sounds[index]) 
                        {
                            sounds[index].cuirrentTime = 0;
                            sounds[index].play();
                            const strArray = sounds[index].src.split("sound/");
                            // title.innerHTML = strArray[1]; js
                            title.text(strArray[1]); //jQ
                        }
                        createBubbles(index);
                    });
            });

            const createBubbles = function(index)
            {
                // visual.innerHTML=""; js
                visual.text(''); // jQ

                /*const bubble = document.createElement("div");
                visual.appendChild(bubble);
                bubble.style.backgroundColor = colors[index];
                bubble.style.top = '300px';
                bubble.style.animation = 'animation 2000ms linear infinite both'; */ //js

                //jQ
                const bubble = $("<div></div>");
                visual.append(bubble);
                bubble.css('background', colors[index]).css('top','300px').css('animation', 'animation 2000ms linear infinite both')
            }
    }
);