window.addEventListener('load',
    function () {
        const sounds = document.querySelectorAll(".sound");
        const pads = document.querySelectorAll(".pads div");
        const visual = document.querySelector(".visual");
        const title = document.querySelector(".title");
        const colors = ["darkgoldenrod", "darkgreen", "darkmagenta", "darkslateblue", "darkslategrey", "darksalmon"];
        sounds.forEach(
            function (snd) {
                snd.onended = function () {
                    visual.innerHTML = "";
                    title.innerHTML = "";
                }
            }
        );
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
        const createBubbles = function(index)
        {
            visual.innerHTML = "";
            const bubble = document.createElement("div");
            visual.appendChild(bubble);
            bubble.style.backgroundColor = colors[index];
            bubble.style.top = '300px';
            bubble.style.animation = 'animation 1000ms linear infinite both';
        }
    }
);