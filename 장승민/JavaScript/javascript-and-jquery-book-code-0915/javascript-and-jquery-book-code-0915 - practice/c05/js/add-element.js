var newEl = document.createElement('li');
var newText = document.createTextNode('퀴노아');
newEl.appendChild(newText);

var position =document.getElementsByTagName('ul')[0];
position.appendChild(newEl);