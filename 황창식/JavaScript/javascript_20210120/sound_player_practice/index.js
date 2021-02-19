window.addEventListener('load', () =>{
    const sounds = document.querySelectorAll(".sound");
    const pads = document.querySelectorAll(".pads div");

    const visual = document.querySelector(".visual");
    const title = document.querySelector(".title");
    const colors = ["lightseagreen", "rgb(178, 32, 112)", "rgb(214, 141, 30)", "rgb(64, 55, 196)", "rgb(4, 184, 13)", "rgb(216, 55, 189)"]

    sounds.forEach(snd => {
        snd.onended = function () {
            visual.innerHTML = "";
            title.innerHTML = "";
        };
    });

    pads.forEach((pad, index) => {
        pad.addEventListener('click', function () {
            sounds.forEach(inx => {
                inx.pause();
            });
            if(sounds[index]){
                sounds[index].currentTime = 0;
                sounds[index].play();

                const strArray = sounds[index].src.split("sound/");
                title.innerHTML = strArray[1];
            }

            createBubbles(index);
        });
    });

    const createBubbles = (index) => {
        visual.innerHTML = "";
        const bubble = document.createElement("div");
        visual.appendChild(bubble);
        bubble.style.backgroundColor = colors[index];
        bubble.style.top = '300px';
        bubble.style.animation = 'animation 2000ms linear infinite both';
    }
});