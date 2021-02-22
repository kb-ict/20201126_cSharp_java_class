// window.addEventListener('load', function () {
$(document).ready(function()
    {
        // const sounds = document.querySelectorAll(".sound");
        const sounds = $(".sound");
        // const pads = document.querySelectorAll(".pads div");
        const pads = $(".pads div");
        // const visual = document.querySelector(".visual");
        const visual = $(".visual");
        // const title = document.querySelector(".title");
        const title = $(".title");
        const colors = ["darkgoldenrod", "darkgreen", "darkmagenta", "darkslateblue", "darkslategrey", "darksalmon"];
        // sounds.forEach(
        //     function (snd) {
        //         snd.onended = function () {
        //             visual.innerHTML = "";
        //             title.innerHTML = "";
        //         }
        //     }
        // );
        sounds.each(function(index,snd)
        {
            snd.onended = function () 
            {
                visual.text('');
                title.text('');
            }    
        })
        // pads.forEach(function (pad, index) {
        pads.each(function(index,pad)
        {
            // pad.addEventListener('click', function () {
            $(pad).on('click',function(){
                //기존에 재생되는 음악을 중지 시켜야 한다.
                // sounds.forEach(function (inx) {
                sounds.each(function(inx,sndf){
                    //console.log(inx);
                    // inx.pause();
                    sndf.pause();
                });
                if (sounds[index]) {
                    sounds[index].currentTime = 0;
                    sounds[index].play();

                    //뮤직 제목을 출력해 준다.
                    //console.log(sounds[index].src) ;
                    const strArray = sounds[index].src.split("sound/");
                    // title.innerHTML = strArray[1];
                    title.text(strArray[1]);
                }

                //볼만들고 애니메이션 하기
                createBubbles(index);
            });
        });
        const createBubbles = function(index)
        {
        //     visual.innerHTML = "";
        //     const bubble = document.createElement("div");
        //     visual.appendChild(bubble);
        //     bubble.style.backgroundColor = colors[index];
        //     bubble.style.top = '300px';
        //     bubble.style.animation = 'animation 1000ms linear infinite both';
        const bubble = $("<div></div>");
        visual.append(bubble);
        bubble.css('background',colors[index]).css('top','300px').css('animation','animation 2000ms linear infinite both');
        }
    }
);