
    
        window.addEventListener('load', function() {
            //NodeList 객체(array가 아니다)에 선택된 모든 노드를 담는다.
            const sounds = document.querySelectorAll(".sound");
            const pads = document.querySelectorAll(".pads div");
            //console.log(sounds);
            const visual = document.querySelector('.visual');
            const title = document.querySelector(".title")
            const colors = [
                "lightseagreen",
                "rgb(178, 32, 112)",
                "rgb(214, 141, 30)",
                "rgb(64, 55, 196)",
                "rgb(4, 184, 13)",
                "rgb(216, 55, 189)"
            ]

            //재생되는 음악이 끝나면 visual에서 비주얼과 제목을 제거
            sounds.forEach(snd => {
                snd.onended = function(){
                    visual.innerHTML = "";
                    title.innerHTML = "";
                };
            });

            pads.forEach((pad, index) => {
                pad.addEventListener('click', function(){
                    //기존에 재생되는 음악을 중지 시켜야 한다.
                   sounds.forEach(inx => {
                    //console.log(inx);
                    inx.pause();
                   });
                   if(sounds[index]){
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

            const createBubbles = (index) => {
                //기존의 애니메이션 visual을 모두 제거하여 초기화 
                visual.innerHTML = "";
                const bubble = document.createElement("div");
                visual.appendChild(bubble);
                bubble.style.backgroundColor =  colors[index];
                bubble.style.top = '300px';
                bubble.style.animation = 'animation 2000ms linear infinite both';
            }

        });
// [출처] 자바스크립트 - 뮤직 플레이어 웹앱 만들기|작성자 코스모스