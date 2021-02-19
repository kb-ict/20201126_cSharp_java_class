var hotItems = document.querySelectorAll('li.hot');

if(hotItems.length>0){

    for(let i =0;hotItems.length>i;i++){
        hotItems[i].className = 'cool';
    }
}