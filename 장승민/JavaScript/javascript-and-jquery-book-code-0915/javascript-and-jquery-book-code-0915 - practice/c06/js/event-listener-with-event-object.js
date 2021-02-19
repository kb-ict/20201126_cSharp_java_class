function checkLentgh(e, minLength) {
    var el, elMsg;
    if (!e) {
        e = window.event;
    }
    el = e.target || e.stcElement;
    elMsg = el.nextSibling;

    if (el.value.length < minLength) {
        elMsg.innerHTML = "name have to over " + minLength + "words.";
    } else {
        elMsg.innerHTML = "";
    }
}
var elUsername = document.getElementById('username');
if (elUsername.addEventListener) {
    elUsername.addEventListener('blur', function (e) {
        checkLentgh(e,5);
    }, false);

} else{
    elUsername.attachEvent('onblur', function(e){
        checkLentgh(e,5);
    });
}