var noteInput, noteName, textEntered, target;
noteInput = document.getElementById('noteInput');
noteName = document.getElementById('noteName');

function writeLabel(e){
    if(!e){
        e= window.event;
    }
    target  = e.target||e.srcElement;
    textEntered = e.target.value;
    noteName.textContent = textEntered;
}
noteInput.addEventListener('input', writeLabel, false);