// jQuery로 변환

// window.addEventListener('load', function () {
$(document).ready(function () {
        // const sounds = document.querySelectorAll(".sound");
        const sounds = $(".sound");

        // const pads = document.querySelectorAll(".pads div");
        const pads = $(".pads div");

        // const visual = document.querySelector('.visual');
        const visual = $('.visual');

        // const title = document.querySelector('.title');
        const title = $('.title');

        const colors = [
            "brown",
            "cornflowerblue",
            "seagreen",
            "tomato",
            "orchid",
            "rgb(255, 255, 95)"
        ];

        // sounds.forEach(
        //     function (snd) {
        //         snd.onended = function () {
        //             visual.innerHTML = "";
        //             title.innerHTML = "";
        //         }
        //     }
        // )
        sounds.each(function (index, soundFile) {
            sounds.onended = function () {
                visual.text('');
                title.text('');

                // 참고
                // 값 읽을때
                // var test = visual.text();

                // 값 쓸때
                // var test = visual.text('aaa');
            }
        });

        // pads.forEach(function (pad, index) {
        //     pad.addEventListener('click', function () {
        //         sounds.forEach(function (inx) {
        //             inx.pause();
        //         });
        //         if (sounds[index]) {
        //             sounds[index].currentTime = 0;
        //             sounds[index].play();
        //             const strArray = sounds[index].src.split("sound/");
        //             title.innerHTML = strArray[1];
        //         }
        //         createBubbles(index);
        //     });
        // });

        // pads.forEach(function(pad, index) {
        pads.each(function (index, pad) {
           
            // pad.addEventListener('click', function () {
            $(pad).on('click', function () {
               
                // sounds.forEach(function(inx) {
                sounds.each(function (inx, sndf) {
                    sndf.pause(); // sndf : 사운드 파일
                });
                if (sounds[index]) {
                    sounds[index].currentTime = 0;
                    sounds[index].play();

                    const strArray = sounds[index].src.split("sound/");
                    
                    // title.innerHTML = strArray[1];
                    title.text(strArray[1]);
                }

                createBubbles(index);
            });
        });

        const createBubbles = function (index) {
            // visual.innerHTML = "";
            visual.text('');

            // javascript
            // const bubble = document.createElement("div");
            // visual.appendChild(bubble);
            // bubble.style.backgroundColor = colors[index];
            // bubble.style.top = '300px';
            // bubble.style.animation = 'animation 2000ms linear infinite both';
            
            // jQuery
            const bubble = $("<div></div>");
            visual.append(bubble);
            bubble.css('background', colors[index]).css('top', '300px').css('animation', 'animation 2000ms linear infinite both');
        }
    }
);